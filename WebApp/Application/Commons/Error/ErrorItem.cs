using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commons.Error
{
    public readonly record struct ErrorItem
    {
        public string ErrorCode { get;  }
        
        public string Message { get; }
        
        private ErrorItem(string errorCode, string message) {
            ErrorCode = errorCode;
            Message = message;
        }
        private ErrorItem(ErrorItem errorItem) {
            ErrorCode = errorItem.ErrorCode;
            Message = errorItem.Message;
        }

        public static ErrorItem Failure(string code = "General.Failure", string message = "A Failure Error")
        {
            return new ErrorItem(code, message);
        }

        public static ErrorItem Unexpected(string code = "General.Unexpected", string message = "A Unexpected Error")
        {
            return new ErrorItem(code, message);
        }

        public static ErrorItem Validation(string code = "General.Validation", string message = "A Validation Error")
        {
            return new ErrorItem(code, message);
        }

        public static ErrorItem NotFound(string code = "General.NotFound", string message = "A NotFound Error")
        {
            return new ErrorItem(code, message);
        }

    }
}
