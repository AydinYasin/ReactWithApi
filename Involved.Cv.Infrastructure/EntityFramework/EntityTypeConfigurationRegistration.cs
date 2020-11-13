using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Involved.Cv.Infrastructure.EntityFramework
{
    public class EntityTypeConfigurationRegistration
    {
        private readonly ModelBuilder _modelBuilder;

        public EntityTypeConfigurationRegistration(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void Register(params Assembly[] assemblies)
        {
            var types = assemblies.SelectMany(a =>
                a.GetTypes().Where(t =>
                    t.GetInterfaces()
                        .Where(i => i.IsGenericType)
                        .Select(i => i.GetGenericTypeDefinition())
                        .Contains(typeof(IEntityTypeConfiguration<>))));

            foreach (var type in types)
            {
                var tIEntityTypeConfiguration = type.GetInterfaces().Where(i => i.IsGenericType).First(i =>
                    i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));

                var tIEntityTypeConfigurationGeneric = tIEntityTypeConfiguration.GetGenericArguments().First();

                var mApplyConfiguration = _modelBuilder.GetType()
                    .GetMethods().First(m =>
                        m.Name == nameof(_modelBuilder.ApplyConfiguration));

                var mApplyConfigurationGeneric =
                    mApplyConfiguration.MakeGenericMethod(tIEntityTypeConfigurationGeneric);
                var entityTypeConfiguration = Activator.CreateInstance(type);
                mApplyConfigurationGeneric.Invoke(_modelBuilder, new[] { entityTypeConfiguration });
            }
        }
    }
}