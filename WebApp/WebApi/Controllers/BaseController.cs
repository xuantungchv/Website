using log4net;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.DTOs;

namespace WebApi.Controllers
{
    public class BaseController : Controller
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(BaseController));

        public IActionResult ResponseRequest(int statusCodes, object? data = null, string message = "")
        {
            
            var response = new ResponseDTO();
            response.StatusCode = statusCodes;
            response.Data = data;
            response.SetMessage(message);
            _logger.Info(new { obj = response, message= "" });
            return Ok(response);
        }
        
        public IActionResult ResponseRequest(int statusCodes, string message)
        {
            var response = new ResponseDTO();
            response.StatusCode = statusCodes;
            response.SetMessage(message);
            _logger.Info(new { obj = response, message = "" });
            return Ok(response);
        }
        public IActionResult ResponseRequest(int statusCodes)
        {
            var response = new ResponseDTO();
            response.StatusCode = statusCodes;
            response.SetMessage(null);
            _logger.Info(new { obj = response, message = "" });
            return Ok(response);
        }
    }
}
