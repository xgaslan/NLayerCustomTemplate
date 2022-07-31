using Microsoft.Extensions.Configuration;

namespace NLayer.Core.Utils;

public static class AppSettingsConfig
{
    private static IConfiguration _configuration { get; set; }

    public static IConfiguration Configuration
    {
        get
        {
            if (_configuration == null)
            {

                var builder = _configuration.GetConnectionString("SqlConnection");
            }

            return _configuration;
        }
    }
}