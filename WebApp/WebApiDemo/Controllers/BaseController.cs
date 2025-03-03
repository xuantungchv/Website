using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApiDemo.Controllers
{
    public class BaseController : ControllerBase
    {
        public IActionResult Problem(List<Error> errors)
        {
            if (errors.All(error => error.Type == ErrorType.Validation)) 
            {
                var modelStateDictionary = new ModelStateDictionary();
                foreach (var error in errors) 
                {
                    modelStateDictionary.AddModelError(error.Code, error.Description);
                }
            }
            return ValidationProblem();
        }
    }
}
