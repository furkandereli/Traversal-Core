using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.MemberLayout
{
    public class _MemberLayoutSidebar:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
