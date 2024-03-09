using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SoftwareCompanyWebSite.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult SignUp()
        //{s
        //    return View();
        //}
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
