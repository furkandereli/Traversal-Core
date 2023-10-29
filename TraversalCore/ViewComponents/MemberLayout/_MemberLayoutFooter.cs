using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.MemberLayout
{
    public class _MemberLayoutFooter:ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
