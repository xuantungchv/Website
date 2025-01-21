namespace Infrastructure.Services.Token
{
    public interface ITokenService
    {
        public string GenerateToken(string userName, string passWord);
    }
}
