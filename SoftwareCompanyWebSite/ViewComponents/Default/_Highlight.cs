using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace SoftwareCompanyWebSite.ViewComponents.Default
{
    public class _Highlight:ViewComponent
    {
        HighlightManager highlightManager = new HighlightManager(new EfHighlightDal());
        public IViewComponentResult Invoke()
        {
            var values = highlightManager.TGetList();
            return View();
        }
    }
}
