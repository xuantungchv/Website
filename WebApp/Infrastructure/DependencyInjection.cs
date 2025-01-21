using Infrastructure.Services.Token;
using Infrastructure.Services.User;

namespace Ifrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddIdentityServerDI(this IServiceCollection services) 
        {
            services.AddScoped<ITokenService, TokenService>();
            //services.AddScoped<IUserServices, UserServices>();
            return services;
        }

        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
            return services;
        }
    }
}
