using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace SoftwareCompanyWebSite.ViewComponents.Default
{
    public class _Stats: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Services.Count();
            ViewBag.v2 =c.TeamMembers.Count();
            ViewBag.v3 = "285";
          return View();
        }
    }
}
