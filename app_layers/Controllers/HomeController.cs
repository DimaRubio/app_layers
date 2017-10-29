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
        //int count;
        //string[] color;
        //public HomeController()
        //{
        //    this.count = 2;
        //    this.color = new string[]{ "red", "green" };
        //}

        public ViewResult Index()
        {
            ViewBag.Message = "Hello ASP.NET Core";
            ViewBag.userName = User.Identity.Name;
            ViewBag.serverName = Server.MachineName;
            ViewBag.clientIP = Request.UserHostAddress;
            ViewBag.dateStamp = HttpContext.Timestamp;

            ColorClass.count = ColorClass.count % 2;
            ViewBag.color = ColorClass.color[ColorClass.count++];

            var currentUser = new User().GetCurrentUser();
            //return View();
            return View(currentUser);
        }

		public ViewResult Error(string id, string name, int? count)
		{
			return View();
		}
    }

    public static class ColorClass
    {
        public static int  count = 2;
        public static string[] color = new string[] { "#F6CECE", "#A9F5A9" };
    }
}