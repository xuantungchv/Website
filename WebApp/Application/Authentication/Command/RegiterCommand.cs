using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Authentication.Command
{
    public record RegiterCommand(string email,string userName,string password) : IRequest;
}
