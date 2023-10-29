using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
