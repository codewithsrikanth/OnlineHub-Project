using OnlineHub.Services.Implementations;
using OnlineHub.Services.Interfaces;
using OnlineHub.WebUI.Helpers;
using OnlineHub.WebUI.Interfaces;

namespace OnlineHub.WebUI.Configuration
{
    public class ConfigurationDependencies
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IUserAccessor, UserAccessor>();
        }
    }
}
