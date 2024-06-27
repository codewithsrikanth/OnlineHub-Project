using Microsoft.AspNetCore.Mvc;

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
