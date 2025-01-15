using Azure;
using Microsoft.AspNetCore.Http;

namespace Ifrastructure.Controllers.DTOs
{
    public class ResponseDTO
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; } ="";
        public object? Data {  get; set; }

        public void SetMessage(string? message)
        {
            switch (StatusCode)
            {
                case StatusCodes.Status200OK:
                    StatusMessage = "Success";
                    break;

                case StatusCodes.Status401Unauthorized:
                    StatusMessage = "Unauthorized";
                    break;

                default:
                    StatusMessage = message;
                    break;
            }
        }

        
    }
}
