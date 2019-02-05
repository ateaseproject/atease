using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Achehre.Framework.Core.ApiExceptions.ApiExceptions;
using Achehre.Framework.Core.ApiExceptions.ApiValidationExceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Achehre.Framework.AspNetCore.Owin.Middleware
{
    public static class ApiErrorHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseApiErrorHandling(this IApplicationBuilder builder,ILogger logger)
        {
            return builder.UseMiddleware<ApiErrorHandlingMiddleware>(logger);
        }
    }


    public class ApiErrorHandlingMiddleware
    {
        public const HttpStatusCode ApiExceptionHttpStatusCode = System.Net.HttpStatusCode.Conflict;
        public const string ApiExceptionReasonPhrase = "Conflict";
        public const string ApiExceptionSwaggerDescription = "Conflict";


        public const HttpStatusCode ApiValidationExceptionHttpStatusCode = System.Net.HttpStatusCode.BadRequest;
        public const string ApiValidationExceptionReasonPhrase = "Bad Request";
        public const string ApiValidationExceptionSwaggerDescription = "Bad Request";


        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        public ApiErrorHandlingMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                switch (exception)
                {
                    case ApiException apiException:
                        apiException.ReferenceCode = context.TraceIdentifier;
                        await SetResponseAndLogContent(_logger, context.Response, ApiExceptionHttpStatusCode, ApiExceptionReasonPhrase,
                            new ApiExceptionContent(apiException));
                        break;
                    case ApiValidationException apiValidationException:
                        apiValidationException.ReferenceCode = context.TraceIdentifier;
                        await SetResponseAndLogContent(_logger, context.Response, ApiValidationExceptionHttpStatusCode, ApiValidationExceptionReasonPhrase,
                            new ApiValidationExceptionContent(apiValidationException));
                        break;

                    default:
                    {
                        throw;
                    }
                }
            }
        }


        public static HttpResponseMessage CreateHttpResponseMessage(ILogger logger, HttpStatusCode statusCode, string reasonPhrase,
            object content)
        {
            var jsonContent = JsonConvert.SerializeObject(content);
            var response = new HttpResponseMessage(statusCode)
            {
                Content = new ObjectContent(jsonContent.GetType(),
                    jsonContent,
                    new JsonMediaTypeFormatter())
            };

            response.ReasonPhrase = reasonPhrase;


            logger.LogDebug(jsonContent);

            return response;
        }

        public static Task SetResponseAndLogContent(ILogger logger, HttpResponse httpResponse, HttpStatusCode statusCode, string reasonPhrase, object content)
        {
            var result = JsonConvert.SerializeObject(content);
            logger.LogDebug(result);

            httpResponse.ContentType = "application/json";
            httpResponse.StatusCode = (int) statusCode;
            httpResponse.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = reasonPhrase;

            return httpResponse.WriteAsync(result);
        }
    }
}