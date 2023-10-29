﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Member.Controllers
{
    [Area("Member")]
	[Route("Member/[controller]/[action]")]
	public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

		public IActionResult GetCitiesSearchByName(string searchString) 
        {
            ViewData["CurrentFilter"] = searchString;
            var values = from x in destinationManager.TGetList() select x ;
            if(!string.IsNullOrEmpty(searchString) )
            {
                values = values.Where(y => y.city.Contains(searchString));
            }
            return View(values.ToList());
        }
    }
}
