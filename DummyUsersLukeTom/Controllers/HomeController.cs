using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DummyUsersLukeTom.Models;

namespace DummyUsersLukeTom.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SecretPage()
        {
            ViewBag.Message = "Secret Page";

            ApplicationDbContext Db = new ApplicationDbContext();

            if (User.Identity.IsAuthenticated)
            {
                return View(Db.Users.ToList());
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
    }
}