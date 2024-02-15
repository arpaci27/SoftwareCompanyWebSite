using Microsoft.AspNetCore.Mvc;

namespace SoftwareCompanyWebSite.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
