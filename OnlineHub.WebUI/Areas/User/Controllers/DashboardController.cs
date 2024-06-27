using Microsoft.AspNetCore.Mvc;

namespace OnlineHub.WebUI.Areas.User.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
