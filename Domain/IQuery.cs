using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Domain
{
	//public interface IQuery<CategoryModel> where CategoryModel : IModel
	//{
	//	List<CategoryModel> Execute();
	//}

	public interface IQuery<TModel> where TModel: IModel
	{
		List<TModel> Get(); // Вроде должен быть ASK, a не execute. execute по идее в ICommand
	}

}
