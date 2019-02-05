using System;
using System.Collections.Generic;

namespace Achehre.Framework.Core.ApiExceptions.ApiValidationExceptions
{
    public class ApiValidationException : Exception, IApiValidationException
    {
        public ApiValidationException(Dictionary<string, string[]> modelState)
        {
            ModelState = modelState ?? throw new ArgumentNullException(nameof(modelState));
        }

        public ApiValidationException(string fieldName, string error)
        {
            var modelState = new Dictionary<string, string[]>();
            modelState.Add(fieldName, new[] {error});

            ModelState = modelState;
        }

        public string ReferenceCode { get; set; }
        public Dictionary<string, string[]> ModelState { get; protected set; }
    }
}