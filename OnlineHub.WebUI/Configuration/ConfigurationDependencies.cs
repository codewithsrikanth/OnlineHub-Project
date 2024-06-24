using OnlineHub.Services.Implementations;
using OnlineHub.Services.Interfaces;

namespace OnlineHub.WebUI.Configuration
{
    public class ConfigurationDependencies
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
        }
    }
}
