using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day6MvcApp.Models;

namespace Day6MvcApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult CreateUser(User u)
        {
            users.Add(u);
            return RedirectToAction("GetAllUsers");
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        static List<User> users = new List<User>();
        public ActionResult GetAllUsers()
        {
            return PartialView(users);
        }

        public ActionResult GetServerTime()
        {
            System.Threading.Thread.Sleep(5000);
            return PartialView();
        }

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
    }
}