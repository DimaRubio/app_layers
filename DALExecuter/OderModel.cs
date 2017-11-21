using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALExecuter
{
	public class OrderModel
	{
		[DBMappingFieldAtribute]
		public int ID { get; set; }
		[DBMappingFieldAtribute]
		public int ID_Order { get; set; }
		[DBMappingFieldAtribute]
		public int ID_Profile { get; set; }
		[DBMappingFieldAtribute]
		public string State_Detail { get; set; }
	}

}
