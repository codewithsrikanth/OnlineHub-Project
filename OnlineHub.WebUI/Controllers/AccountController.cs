using Microsoft.AspNetCore.Mvc;
using OnlineHub.Entities;
using OnlineHub.Services.Interfaces;
using OnlineHub.WebUI.Models;

namespace OnlineHub.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private IAuthenticationService _authService;
        public AccountController(IAuthenticationService _authService)
        {
            this._authService = _authService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _authService.AuthenticateUser(model.Email, model.Password);
                if(user != null)
                {
                    if (user.Roles.Contains("Admin"))
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                    }
                    else if (user.Roles.Contains("User"))
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "User" });
                    }
                }
            }
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            if(ModelState.IsValid)
            {
                User user = new User
                {
                    Name = model.Name,
                    Email = model.Email,
                    UserName = model.Email,
                    PhoneNumber = model.PhoneNumber,
                };
                bool result = _authService.CreateUser(user, model.Password);
                if (result)
                {
                    return RedirectToAction("Login");
                }
            }
            return View();
        }
    }
}
