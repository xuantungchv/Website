using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Authentication.Query
{
    public record LoginQuery(string userName, string password) : IRequest<string>;
}
