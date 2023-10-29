using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commantManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = commantManager.TGetListCommentWithDestinationAndUser(id);
            ViewBag.Comment = values.Count();
            return View(values);
        }

    }
}
