using Application.Services.Token;
using Application.Services.User;
using Infratructure.Responsitory;
using Infratructure.Responsitory.Entity;
using Infratructure.Services.Token;
using Infratructure.Services.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infratructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDI(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddIdentity<Users, IdentityRole>().AddEntityFrameworkStores<WebappContext>().AddDefaultTokenProviders();

            services.AddIdentityServer(options =>
            {
                options.Events.RaiseErrorEvents = true;
                options.Events.RaiseInformationEvents = true;
                options.Events.RaiseFailureEvents = true;
                options.Events.RaiseSuccessEvents = true;
                //options.EmitStaticAudienceClaim = true;
            }).AddAspNetIdentity<Users>()
            .AddInMemoryClients(Config.GetClients()) // Khai báo client
    .AddInMemoryIdentityResources(Config.GetIdentityResources()) // Khai báo IdentityResource
    .AddInMemoryApiScopes(Config.GetApiScopes()) // Khai báo API Scope
    .AddDeveloperSigningCredential(); // Sử dụng chứng chỉ dev (không dùng cho production);
            services.AddDbContext<WebappContext>((options) =>
            {
                options.UseSqlServer(ConfigurationHelper.GetByKey("ConnectionStrings:WebappDatabase"));
            });
            return services;
        }
    }
}
