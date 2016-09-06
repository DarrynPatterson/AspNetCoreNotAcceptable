using AspNetCoreNotAcceptable.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreNotAcceptable.HttpResults
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