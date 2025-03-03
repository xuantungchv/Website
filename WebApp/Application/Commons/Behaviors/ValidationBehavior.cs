using Application.Commons.Error;
using Application.Commons.Security;
using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commons.Behaviors
{
    public class ValidationBehavior<IRequest, IResponse> : IPipelineBehavior<IRequest, IResponse> where IRequest : IAuthorizeableRquest<IResponse>  where IResponse : IErrorOr
    {
        public async Task<IResponse> Handle(IRequest request, RequestHandlerDelegate<IResponse> next, CancellationToken cancellationToken)
        {


            return await next();
            throw new NotImplementedException();
        }
    }
}
