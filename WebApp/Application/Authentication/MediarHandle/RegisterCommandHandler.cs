using Application.Authentication.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Authentication.MediarHandle
{
    internal class RegisterCommandHandler : IRequestHandler<RegiterCommand>
    {


        public Task Handle(RegiterCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }  
     
}
