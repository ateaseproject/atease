using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;

namespace Achehre.Framework.AspNetCore.Owin.Attributes
{
    public class AllowedControllersAuthorizationFilter : IAsyncAuthorizationFilter
    {
        private readonly IOptions<AchehreFrameworkOptions> _asanPardakhtFrameworkOptions;

        public AllowedControllersAuthorizationFilter(
            IOptions<AchehreFrameworkOptions> asanPardakhtFrameworkOptions)
        {
            _asanPardakhtFrameworkOptions = asanPardakhtFrameworkOptions;
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var controllerActionDescriptor = context.ActionDescriptor as ControllerActionDescriptor;
            var controllerName = controllerActionDescriptor?.ControllerName.ToLower();

            if (!_asanPardakhtFrameworkOptions.Value.AllowedControllers.Select(c => c.ToLower())
                .Contains(controllerName))
            {
                throw new ControllerNotFoundApiException(controllerName);
            }
        }
    }
}