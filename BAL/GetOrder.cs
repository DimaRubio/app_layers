using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Domain;

namespace BAL
{
	public class GetOrder : IGetOrder
	{
		public List<OrderModel> Get()
		{
			var result = new List<OrderModel>();
			result.Add(new OrderModel() { ID = 1, ID_Order = 10001,ID_Profile = 001, State_Detail = "Proccessing" });
			result.Add(new OrderModel() { ID = 2, ID_Order =10002, ID_Profile = 002, State_Detail = "Complete" });
			return result;
			//throw new NotImplementedException();
		}
	}
}
