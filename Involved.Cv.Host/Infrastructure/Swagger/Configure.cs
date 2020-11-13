using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Involved.Cv.Host.Infrastructure.Swagger
{
    public static class Configure
    {
        public static IServiceCollection AddInvolvedSwagger(this IServiceCollection services,
            IConfiguration configuration)
        {
            return services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Invovled Cv Api", Version = "v1" });
                options.DescribeAllEnumsAsStrings();
            });
        }


        public static IApplicationBuilder UseInvolvedSwagger(this IApplicationBuilder app,
            IConfiguration configuration)
        {
            app.UseSwagger();

            app.UseSwaggerUI(options => { options.SwaggerEndpoint("/swagger/v1/swagger.json", "Invovled Cv Api"); });

            return app;
        }
    }
}