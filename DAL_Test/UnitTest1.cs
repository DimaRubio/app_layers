using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DALExecuter;

namespace DAL_Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var dbExecuter = new DBExecuter();
			var query = "select ID=1";
			var result = dbExecuter.RunQuery(query);
		}

		//[TestMethod]
		//public void TestMethod2()
		//{
		//	var dbExecuter = new DBExecuter();
		//	var query = "select ID=1, name ="somename";
		//	var result = dbExecuter.RunQuery(query);
		//}
	}
}
