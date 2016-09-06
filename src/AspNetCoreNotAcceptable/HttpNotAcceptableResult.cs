using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreNotAcceptable
{
    public class HttpNotAcceptableResult : ObjectResult
    {
        public HttpNotAcceptableResult()
            : base(NotAcceptableModel.Create())
        {
            StatusCode = 406;
        }
    }
}