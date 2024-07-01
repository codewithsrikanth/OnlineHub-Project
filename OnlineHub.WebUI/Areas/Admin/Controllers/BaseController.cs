using Microsoft.AspNetCore.Mvc;
using OnlineHub.WebUI.Helpers;

namespace OnlineHub.WebUI.Areas.Admin.Controllers
{
    [CustomAuthorize(Roles ="Admin")]
    [Area("Admin")]
    public class BaseController : Controller
    {
       
    }
}
