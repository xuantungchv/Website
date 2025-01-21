namespace Infrastructure.Services.User
{
    public interface IUserServices
    {
        Task<bool> AuthenUser(string userName, string passWord);
    }
}
