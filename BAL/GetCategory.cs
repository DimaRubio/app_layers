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
		public List<CategoryModel> Get()
		{
			var result = new List<CategoryModel>();
			result.Add(new CategoryModel() { ID = 1, Name = "Outerwear" , Description= "Outerwear lorem insput" });
			result.Add(new CategoryModel() { ID = 2, Name = "Shoes" , Description= "Shoes lorem insput" });
			return result;
			//throw new NotImplementedException();
		}
	}
}
