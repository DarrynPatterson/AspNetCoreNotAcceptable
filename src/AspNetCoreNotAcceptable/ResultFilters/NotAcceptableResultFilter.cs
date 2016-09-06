using AspNetCoreNotAcceptable.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AspNetCoreNotAcceptable.ResultFilters
{
    public class NotAcceptableResultFilter : ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var result = context.Result as StatusCodeResult;

            if (result != null && result.StatusCode == 406)
            {
                context.Result = new HttpNotAcceptableResult();
            }
        }
    }
}