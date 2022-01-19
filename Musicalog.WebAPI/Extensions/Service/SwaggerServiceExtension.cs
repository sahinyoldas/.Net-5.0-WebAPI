using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Musicalog.WebAPI.Extensions.Service
{
    public static class SwaggerServiceExtension
    {
        public static void AddSwaggerExtension(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Musicalog.WebAPI",
                    Version = "v1",
                    Contact = new OpenApiContact()
                    {
                        Name = "SAHIN YOLDAS",
                        Email = "sahinyoldas@gmail.com"
                    }
                });
            });
        }
    }
}
