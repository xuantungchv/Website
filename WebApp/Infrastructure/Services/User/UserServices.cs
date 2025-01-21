using Azure.Core;
using Ifrastructure.Responsitory.Entity;
using log4net;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Services.User
{
    public class UserServices : IUserServices
    {
        private readonly SignInManager<Users> _signInManager;
        private readonly ILog _logger = LogManager.GetLogger(typeof(UserServices));

        public UserServices(SignInManager<Users> signInManager) 
        {
            _signInManager = signInManager;

        }
        public async Task<bool> AuthenUser(string userName, string passWord)
        {
            try
            {

                if (userName == null || passWord == null)
                    return false;
                var user = new Users
                {
                    UserName = userName,
                    Email = "111@gamil.com"

                };
                var response = await _signInManager.PasswordSignInAsync(userName, passWord, false, false);
                if (response != null && response.Succeeded)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
