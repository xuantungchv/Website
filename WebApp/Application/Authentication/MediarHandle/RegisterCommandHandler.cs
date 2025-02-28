using Application.Authentication.Command;
using Application.Services.Token;
using Application.Services.User;
using MediatR;

namespace Application.Authentication.MediarHandle
{
    public class RegisterCommandHandler : IRequestHandler<RegiterCommand>
    {

        private readonly ITokenService _tokenService;
        private readonly IUserServices _userServices;
        public RegisterCommandHandler(ITokenService tokenService, IUserServices userServices)
        {
            _tokenService = tokenService;
            _userServices = userServices;
        }

        public async Task Handle(RegiterCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _userServices.AddUser(request.userName, request.password, request.email);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }

}
