using System;
using CommandLine;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace Involved.Cv.Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = null;
            var options = new Options();
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(opts =>
                {
                    connectionString = opts.ConnectionString;
                    options = opts;
                })
                .WithNotParsed((errs) => throw new ArgumentException(string.Join(Environment.NewLine, errs)));
            var serviceProvider = CreateServices(connectionString, options);


            using (var scope = serviceProvider.CreateScope())
            {
                UpdateDatabase(scope.ServiceProvider);
            }
        }

        private static IServiceProvider CreateServices(string connectionString, Options options)
        {
            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(connectionString)
                    .ScanIn(typeof(Program).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .AddSingleton(options)
                .BuildServiceProvider(false);
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            var options = serviceProvider.GetRequiredService<Options>();
            if (options.Reset)
            {
                Retry(() => runner.Processor.Execute(GetClearScript()), 5);
            }

            runner.MigrateUp();
        }

        private static void Retry(Action action, int count)
        {
            for (var i = 0; i < count; i++)
            {
                try
                {
                    action();
                    break;
                }
                catch (Exception)
                {
                    if (i == count)
                    {
                        throw;
                    }
                }
            }
        }

        private static string GetClearScript()
        {
            return @"DECLARE @Sql NVARCHAR(500) DECLARE @Cursor CURSOR
                    SET @Cursor = CURSOR FAST_FORWARD FOR
                    SELECT DISTINCT sql = 'ALTER TABLE [' + tc2.TABLE_NAME + '] DROP [' + rc1.CONSTRAINT_NAME + ']'
                    FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS rc1
                    LEFT JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc2 ON tc2.CONSTRAINT_NAME =rc1.CONSTRAINT_NAME
                    
                    OPEN @Cursor FETCH NEXT FROM @Cursor INTO @Sql
                    
                    WHILE (@@FETCH_STATUS = 0)
                    BEGIN
                    Exec sp_executesql @Sql
                    FETCH NEXT FROM @Cursor INTO @Sql
                    END
                    
                    CLOSE @Cursor DEALLOCATE @Cursor
                    GO
                    
                    EXEC sp_MSforeachtable 'DROP TABLE ?'
                    GO";
        }
    }
}