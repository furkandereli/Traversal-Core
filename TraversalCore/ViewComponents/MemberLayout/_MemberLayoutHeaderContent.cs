using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.MemberLayout
{
    public class _MemberLayoutHeaderContent:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
