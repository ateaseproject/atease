using System;
using System.Linq;
using Achehre.Framework.Core.ApiExceptions.ApiValidationExceptions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Achehre.Framework.AspNetCore.Owin.Attributes
{
    public class ModelStateValidationFilterAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var modelStateDic = context.ModelState.ToDictionary(m => m.Key,
                    m => m.Value.Errors.Select(e => e.Exception?.ToString() ?? e.ErrorMessage).ToArray());
                throw new ApiValidationException(modelStateDic);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}