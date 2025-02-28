using Application.Authentication.Query;
using Application.Services.Token;
using Application.Services.User;
using MediatR;

namespace Application.Authentication.MediarHandle
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, string>
    {
        private readonly ITokenService _tokenService;
        private readonly IUserServices _userServices;
        public LoginQueryHandler(ITokenService tokenService, IUserServices userServices)
        {
            _tokenService = tokenService;
            _userServices = userServices;
        }
        public async Task<string> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            try
            {
                await _userServices.AuthenUser(request.userName, request.password);
                return _tokenService.GenerateToken(request.userName, request.password);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
