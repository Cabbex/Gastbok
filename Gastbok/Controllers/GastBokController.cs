using Gastbok.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gastbok.ViewModel;

namespace Gastbok.Controllers
{
    public class GastBokController : Controller
    {
        private ApplicationDbContext _context;

        public GastBokController() {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing) {
            _context.Dispose();
        }
        // GET: /Home/GastBok
        public ActionResult Index()
        {
            var GetComments = _context.Comments.ToList();
            foreach(var comment in GetComments) {
                var user = _context.Users.SingleOrDefault(e => e.Id == comment.UserId);
                comment.UserId = user.UserName;
            }
            var viewModel = new GastBokViewModel {
                dbComments = GetComments,
                Comment = new Comment()
            };
            return View(viewModel);
        }

        // POST: /Home/Gastbok
        [HttpPost]
        public ActionResult PostComment(Comment comment) {
            comment.DateTime = DateTime.Now;
            comment.UserId = User.Identity.GetUserId();

            _context.Comments.Add(comment);
            _context.SaveChanges();
            return RedirectToAction("Index", "Gastbok");
        }
    }
}