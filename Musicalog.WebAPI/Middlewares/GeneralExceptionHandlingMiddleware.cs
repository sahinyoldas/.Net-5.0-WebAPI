using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace Musicalog.WebAPI.Middlewares
{
    public class GeneralExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public GeneralExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                await HandleException(context, error);
            }
        }

        private async Task HandleException(HttpContext context, Exception error)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            switch (error)
            {
                case DivideByZeroException e:
                    // divide by zero xxception error
                    response.StatusCode = (int)HttpStatusCode.NotImplemented;
                    break;
                case UnauthorizedAccessException e:
                    // divide by zero xxception error
                    response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    break;
                default:
                    // unhandled error
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            var result = JsonSerializer.Serialize(new { Message = error?.Message, StatusCode = response.StatusCode });
            await response.WriteAsync(result);
        }

    }
}
