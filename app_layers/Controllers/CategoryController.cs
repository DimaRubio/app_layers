using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;

namespace app_layers.Controllers
{
    public class CategoryController : Controller
    {
		private IGetCategory getCategory;

		public CategoryController(IGetCategory getCategory)
		{
			this.getCategory = getCategory;
		}

		// GET: Category
		public ActionResult GetCategory()
        {
			var model = getCategory.Execute();
            return View("Index", model);
        }
    }
}