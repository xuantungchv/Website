using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

public static class ConfigurationHelper
{
    public static IConfiguration _configuration { get; private set; }

    static ConfigurationHelper()
    {
        _configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
    }

    public static string GetByKey(string key)
    {
        return _configuration[key];
    }
}
