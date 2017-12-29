using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokerSignalR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Chat()
        {
            return PartialView("_Chat");
        }
        [HttpGet]
        public ActionResult Contact(string sessionid)
        {
            ViewBag.SessionID = "?sessionid="+ sessionid;
            //Redirect("About");
            return View();

        }
        public ActionResult About(string sessionid)
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.SessionID = sessionid;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}