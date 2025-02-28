using Application.Services.User;
using Azure.Core;
using Infratructure.Responsitory.Entity;
using Microsoft.AspNetCore.Identity;

namespace Infratructure.Services.User
{
    public class UserServices : IUserServices
    {
        private readonly SignInManager<Users> _signInManager;
        private readonly UserManager<Users> _userManager;
        //private readonly ILog _logger = LogManager.GetLogger(typeof(UserServices));

        public UserServices(SignInManager<Users> signInManager, UserManager<Users> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }
        public async Task AuthenUser(string userName, string passWord)
        {
            try
            {
                if (userName == null || passWord == null)
                    throw new Exception("Thông tin không được bỏ trống");
                 
                var userExist = await _userManager.FindByNameAsync(userName);
                if (userExist == null)
                    throw new Exception("Tài khoản hoặc mật khẩu không đúng");

                var response = await _signInManager.CheckPasswordSignInAsync(userExist,passWord,false);
                if (response != null && response.Succeeded)
                    return;
                throw new Exception("Tài khoản hoặc mật khẩu không đúng");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task AddUser(string userName, string passWord, string email)
        {
            try
            {
                if (userName == null || passWord == null || email == null)
                    throw new Exception("Thông tin không được bỏ trống");
                
                var userEixt = await _userManager.FindByLoginAsync(userName, passWord);
                if (userEixt != null)
                    throw new Exception("Đã tồn tại user này");
                var user = new Users
                {
                    UserName = userName,
                    Email = email,
                };
                var response = await _userManager.CreateAsync(user);
                if (response != null && response.Succeeded)
                    response = await _userManager.AddPasswordAsync(user, passWord);
                else
                    throw new Exception("Không tạo được user này");
                if (response != null && response.Succeeded)
                    return;
                    throw new Exception("Không tạo được user này");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
