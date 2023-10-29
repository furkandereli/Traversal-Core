﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.TGetListCommentWithDestination();
            return View(values);
        }

        public IActionResult DeleteComment(int id) 
        {
            var values = _commentService.GetById(id);
            _commentService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
