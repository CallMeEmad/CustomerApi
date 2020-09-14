using CustomerApi.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace CustomerApi.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                    if (contextFeature != null)
                    {
                        var n = new ErrorModel()
                        {
                            StatusCode = context.Response.StatusCode,
                            Title = "Internal Server Error.",
                            Detail = contextFeature.Error.Message,
                            Instance = "instance url",
                            Type = "type url"
                        }.ToString();

                await context.Response.WriteAsync(n);
            }
                });
            });
        }
    }
}
