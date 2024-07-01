using Microsoft.AspNetCore.Mvc;
using OnlineHub.WebUI.Helpers;

namespace OnlineHub.WebUI.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
