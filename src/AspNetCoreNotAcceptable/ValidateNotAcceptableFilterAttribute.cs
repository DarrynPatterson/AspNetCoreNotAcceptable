using System.Linq;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AspNetCoreNotAcceptable
{
    public class ValidateNotAcceptableFilterAttribute : ActionFilterAttribute
    {
        private const string AllMimeTypes = "*/*";

        private const string AcceptableMimeType = "application/json";

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Do not proceed if this is an invalid request object
            if (context.HttpContext == null || context.HttpContext.Request == null)
            {
                return;
            }

            var request = context.HttpContext.Request;

            // Validate the "Accept" header for all requests
            if (!IsValidMediaType(request.Headers["Accept"]))
            {
                request.Headers["Accept"] = string.Empty;

                // "Not Acceptable" HTTP result
                context.Result = new HttpNotAcceptableResult();

                return;
            }
        }

        private bool IsValidMediaType(string acceptHeader)
        {
            if (string.IsNullOrWhiteSpace(acceptHeader))
            {
                return false;
            }

            var acceptTypes = acceptHeader.Split(',');
            if (!acceptTypes.Contains(AllMimeTypes) && !acceptTypes.Contains(AcceptableMimeType))
            {
                return false;
            }

            return true;
        }
    }
}