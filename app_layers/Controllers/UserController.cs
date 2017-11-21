using app_layers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace app_layers.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult CreateNewUser()
        {
            return View();
        }

		[HttpPost]
		public ActionResult AddUser(MVCUserModel model)
		{
			if (ModelState.IsValid)
			{
				return Redirect("~/user/CreateNewUser");
				//return View("CreateNewUser");
			}
			else return Redirect("https://www.google.com.ua");

		}

		[HttpPost]
		public JsonResult AddUserJQ(MVCUserModel model)
		{
			return new JsonResult()
			{
				Data = "Successfull request"
			};
		}
	}
}