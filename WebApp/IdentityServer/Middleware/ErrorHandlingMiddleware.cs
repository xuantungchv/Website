using Newtonsoft.Json;
using System.Net;

namespace IdentityServer.Middleware
{

    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public ErrorHandlingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _requestDelegate(context);

            }
            catch (Exception ex)
            {
                await HandleExceptionError(context,ex);
                //throw;
            }
        }
        
        private static Task HandleExceptionError(HttpContext context, Exception ex) 
        {
        var response = context.Response;
            context.Response.StatusCode = ((int)HttpStatusCode.InternalServerError);
            context.Response.ContentType = "application/json";
            var es = JsonConvert.SerializeObject("Co loi xay ra");
            return context.Response.WriteAsync(es);
        }
    }
}
