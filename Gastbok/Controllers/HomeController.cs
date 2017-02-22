using Gastbok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace Gastbok.Controllers {
    public class HomeController : Controller {

        // GET: /Index
        public ActionResult Index() {
            return View();
        }
        // GET: /Home/About
        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}