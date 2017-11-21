using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;

namespace app_layers.Controllers
{
    public class OrderController : Controller
    {
        
		private IGetOrder getOrder;

		public OrderController(IGetOrder getOrder)
		{
			this.getOrder = getOrder;
		}

		// GET: Order
		public ActionResult GetOrder()
		{
			var model = getOrder.Get();
			return View("Index", model);
		}
	}
}