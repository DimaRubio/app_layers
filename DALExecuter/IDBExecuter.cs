using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALExecuter
{
	public interface IDBExecuter : IDisposable
	{
		List<OrderModel> RunQuery(string query);
	}
}
