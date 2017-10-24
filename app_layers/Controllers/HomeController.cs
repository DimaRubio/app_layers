using app_layers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace app_layers.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            var user1 = new UserInformation(1);
            user1.FirstName = "Dima";
            user1.LastName = "Bolyachin";
            return View(user1);
        }
    }
}