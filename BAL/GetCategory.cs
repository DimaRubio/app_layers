using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Domain;

namespace BAL
{
	public class GetCategory : IGetCategory
	{
		public List<CategoryModel> Execute()
		{
			var result = new List<CategoryModel>();
			result.Add(new CategoryModel() { ID = 1 });
			return result;
			//throw new NotImplementedException();
		}
	}
}
