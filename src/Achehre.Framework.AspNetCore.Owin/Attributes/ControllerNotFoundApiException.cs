using System;
using System.Collections.Generic;
using System.Text;
using Achehre.Framework.Core.ApiExceptions.ApiExceptions;

namespace Achehre.Framework.AspNetCore.Owin.Attributes
{
    public class ControllerNotFoundApiException : ApiException
    {
        public ControllerNotFoundApiException(string controllerName)
        {
            DevelopperMessage = $"Controller '{controllerName}' not found";
        }
    }
}
