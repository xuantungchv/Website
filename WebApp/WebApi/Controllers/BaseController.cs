using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.DTOs;

namespace WebApi.Controllers
{
    public class BaseController : Controller
    {
        private readonly ILogger<BaseController> _logger;

        public BaseController(ILogger<BaseController> logger)
        {
            _logger = logger;
        }

        public IActionResult ResponseRequest(int statusCodes, object? data = null, string message = "")
        {
            
            var response = new ResponseDTO();
            response.StatusCode = statusCodes;
            response.Data = data;
            response.SetMessage(message);
            _logger.LogInformation("", response);
            return Ok(response);
        }
        
        public IActionResult ResponseRequest(int statusCodes, string message)
        {
            var response = new ResponseDTO();
            response.StatusCode = statusCodes;
            response.SetMessage(message);
            _logger.LogInformation("", response);
            return Ok(response);
        }
        public IActionResult ResponseRequest(int statusCodes)
        {
            var response = new ResponseDTO();
            response.StatusCode = statusCodes;
            response.SetMessage(null);
            _logger.LogInformation("", response);
            return Ok(response);
        }
    }
}
