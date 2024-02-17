using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace SoftwareCompanyWebSite.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        public IActionResult Index()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Details(Service s)
        {
            return View();
        }
    }
}
