using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commons.Security
{
    public interface IAuthorizeableRquest<T> : IRequest<T> 
    {
        Guid UserId { get; }
    }
}
