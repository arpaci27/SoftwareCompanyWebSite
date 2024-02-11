using Microsoft.AspNetCore.Mvc;

namespace SoftwareCompanyWebSite
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
