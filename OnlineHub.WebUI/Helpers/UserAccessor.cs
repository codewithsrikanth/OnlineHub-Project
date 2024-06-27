using Microsoft.AspNetCore.Identity;
using OnlineHub.Entities;
using OnlineHub.WebUI.Interfaces;

namespace OnlineHub.WebUI.Helpers
{
    public class UserAccessor : IUserAccessor
    {
        private readonly UserManager<User> _userManager;
        private IHttpContextAccessor _contextAccessor;
        public UserAccessor(UserManager<User> _userManager, IHttpContextAccessor _contextAccessor)
        {
            this._userManager = _userManager;
            this._contextAccessor = _contextAccessor;
        }

        public User GetUser()
        {
            if (_contextAccessor.HttpContext.User != null)
            {
                return _userManager.GetUserAsync(_contextAccessor.HttpContext.User).Result;
            }
            else 
            { 
                return null; 
            }
        }
    }
}
