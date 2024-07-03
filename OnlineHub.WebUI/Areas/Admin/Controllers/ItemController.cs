using Microsoft.AspNetCore.Mvc;
using OnlineHub.Services.Interfaces;

namespace OnlineHub.WebUI.Areas.Admin.Controllers
{
    public class ItemController : BaseController
    {
        ICatalogService _catalogService;
        public ItemController(ICatalogService _catalogService)
        {
            this._catalogService = _catalogService;
        }
        public IActionResult Index()
        {
            var data = _catalogService.GetItems();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
