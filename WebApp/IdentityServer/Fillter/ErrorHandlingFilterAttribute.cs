using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace IdentityServer.Fillter
{
    public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception; 
            context.Result = new ObjectResult(new {error = "Co loi xay ra vui long nhap lai" })
            {
                StatusCode = 500
            };
        context.ExceptionHandled = true;
        }
        
    }
}
