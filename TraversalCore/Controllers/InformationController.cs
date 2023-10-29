using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
	public class InformationController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
