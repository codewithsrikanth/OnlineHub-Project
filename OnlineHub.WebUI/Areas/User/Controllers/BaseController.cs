using Microsoft.AspNetCore.Mvc;
using OnlineHub.WebUI.Helpers;

namespace OnlineHub.WebUI.Areas.User.Controllers
{
    [CustomAuthorize(Roles = "User")]
    [Area("User")]
    public class BaseController : Controller
    {
       
    }
}
