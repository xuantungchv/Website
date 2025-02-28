namespace Application.Services.Token
{
    public interface ITokenService
    {
        string GenerateToken(string userName, string passWord);
    }
}
