using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Achehre.Framework.AspNetCore.Owin.Middleware
{
    public static class ExceptionMiddlewareExtensions
    {
        public const HttpStatusCode HttpStatusCode = System.Net.HttpStatusCode.InternalServerError;
        public const string ReasonPhrase = "Internal Server Error";
        public const string SwaggerDescription = "Internal Server Error";

        public static void ConfigureExceptionHandler(this IApplicationBuilder app, ILogger logger)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    var globalExceptionContent = new GlobalExceptionContent(context.TraceIdentifier);


                    context.Response.StatusCode = (int) HttpStatusCode;
                    context.Response.ContentType = "application/json";
                    context.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = ReasonPhrase;


                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        logger.LogError($"This should not have happened!: {contextFeature.Error}");
                        await context.Response.WriteAsync(JsonConvert.SerializeObject(globalExceptionContent));
                    }
                });
            });
        }
    }
}