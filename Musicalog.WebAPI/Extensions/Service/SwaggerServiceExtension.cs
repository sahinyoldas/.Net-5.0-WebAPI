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

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                   {
                     new OpenApiSecurityScheme
                     {
                       Reference = new OpenApiReference
                       {
                         Type = ReferenceType.SecurityScheme,
                         Id = "Bearer"
                       }
                      },
                      new string[] { }
                    }
                  });
            });
        }
    }
}
