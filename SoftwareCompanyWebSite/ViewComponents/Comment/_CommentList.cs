using Microsoft.AspNetCore.Mvc;

namespace SoftwareCompanyWebSite.ViewComponents.Comment
{
    public class _CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
