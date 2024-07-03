using Microsoft.AspNetCore.Mvc;
using OnlineHub.Entities;
using OnlineHub.Services.Interfaces;
using OnlineHub.WebUI.Interfaces;
using OnlineHub.WebUI.Models;

namespace OnlineHub.WebUI.Areas.Admin.Controllers
{
    public class ItemController : BaseController
    {
        ICatalogService _catalogService;
        IFileHelper _fileHelper;
        public ItemController(ICatalogService _catalogService, IFileHelper _fileHelper)
        {
            this._catalogService = _catalogService;
            this._fileHelper = _fileHelper;
        }
        public IActionResult Index()
        {
            var data = _catalogService.GetItems();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories =  _catalogService.GetCategories();
            ViewBag.ItemTypes = _catalogService.GetItemsTypes();
            return View();
        }
        [HttpPost]
        public IActionResult Create(ItemModel model)
        {
            try
            {
                model.ImageUrl = _fileHelper.UploadFile(model.File);
                Item data = new Item
                {
                    Name = model.Name,
                    UnitPrice = model.UnitPrice,
                    CategoryId = model.CategoryId,
                    ItemTypeId = model.ItemTypeId,
                    Description = model.Description,
                    ImageUrl = model.ImageUrl,
                };
                _catalogService.AddItem(data);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                ViewBag.Categories = _catalogService.GetCategories();
                ViewBag.ItemTypes = _catalogService.GetItemsTypes();
                return View();
            }           
        }
    }
}
