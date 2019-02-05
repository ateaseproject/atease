using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;

namespace Achehre.Framework.AspNetCore.Owin
{
    public class ApiExceptionContentFactory
    {
        private HttpResponseMessage Create(HttpStatusCode statusCode, string reasonPhrase,
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

            return response;
        }
    }
}