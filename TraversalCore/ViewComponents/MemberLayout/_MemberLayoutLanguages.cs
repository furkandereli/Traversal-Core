using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.MemberLayout
{
    public class _MemberLayoutLanguages:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
