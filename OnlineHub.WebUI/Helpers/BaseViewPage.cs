using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using OnlineHub.Entities;
using OnlineHub.WebUI.Interfaces;

namespace OnlineHub.WebUI.Helpers
{
    public abstract class BaseViewPage<TModel> : RazorPage<TModel>
    {
        [RazorInject]
        public IUserAccessor _userAccessor { get; set; }
        public User CurrentUser
        {
            get
            {
                if (User != null)
                    return _userAccessor.GetUser();
                else
                    return null;

            }
        }
    }
}
