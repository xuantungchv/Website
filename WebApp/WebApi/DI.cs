using WebApi.Services.Token;

namespace WebApi
{
    public class DI
    {
        private WebApplicationBuilder _applicationBuilder;
        public DI(WebApplicationBuilder applicationBuilder) 
        {
            _applicationBuilder = applicationBuilder;

        }
        public void build() 
        {
            _applicationBuilder.Services.AddSingleton<ITokenService, TokenService>();
        }
    }
}
