using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class OrderModel : IModel
	{
		public int ID { get; set; }
		public int ID_Order { get; set; }
		public int ID_Profile { get; set; }
		public string State_Detail { get; set; }
	}
}
