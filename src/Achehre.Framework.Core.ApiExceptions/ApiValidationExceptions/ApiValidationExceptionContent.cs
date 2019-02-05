using System.Collections.Generic;

namespace Achehre.Framework.Core.ApiExceptions.ApiValidationExceptions
{
    public class ApiValidationExceptionContent : IApiValidationException
    {
        public ApiValidationExceptionContent(IApiValidationException apiValidationException)
        {
            ReferenceCode = apiValidationException.ReferenceCode;
            ModelState = apiValidationException.ModelState;
        }

        public string ReferenceCode { get; set; }
        public Dictionary<string, string[]> ModelState { get; set; }
    }
}