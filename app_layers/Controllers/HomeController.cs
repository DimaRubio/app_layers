using app_layers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAL;

namespace app_layers.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            ViewBag.Message = "Hello ASP.NET Core";
            ViewBag.userName = User.Identity.Name;
            ViewBag.serverName = Server.MachineName;
            ViewBag.clientIP = Request.UserHostAddress;
            ViewBag.dateStamp = HttpContext.Timestamp;
            var currentUser = new User().GetCurrentUser();
            return View(currentUser);
        }
    }
}