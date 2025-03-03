using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commons.Error
{
    public interface IErrorHandle
    {
        List<ErrorItem>? Errors { get; }
        public bool IsError { get; }    
    }
}
