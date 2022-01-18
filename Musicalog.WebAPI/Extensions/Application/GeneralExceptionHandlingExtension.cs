using Microsoft.AspNetCore.Builder;
using Musicalog.WebAPI.Middlewares;

namespace Musicalog.WebAPI.Extensions
{
    public static class GeneralExceptionHandlingExtension
    {
        public static void AddGeneralExceptionHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<GeneralExceptionHandlingMiddleware>();
        }
    }
}
