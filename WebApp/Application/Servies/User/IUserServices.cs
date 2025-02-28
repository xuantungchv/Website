namespace Application.Services.User
{
    public interface IUserServices
    {
        Task AuthenUser(string userName, string passWord);
        Task AddUser(string userName, string passWord,string email);
    }
}
