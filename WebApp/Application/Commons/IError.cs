using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commons
{
    public interface IError
    {
        string Message { get; } 
        string ErrorCode { get; }   
    }
}
