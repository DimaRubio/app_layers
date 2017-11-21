using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DALExecuter
{
    public class DBExecuter : IDBExecuter
    {
		public void Dispose()
		{
			//throw new NotImplementedException();
		}

		public List<OrderModel> RunQuery(string query)
		{
			var result = new List<OrderModel>();
			//var connection = new SqlConnection(
			//"Data Source=CASTLE-PC;Database=master;User=adminsql;password=123456"); // using System.Data.SqlClient;
			var connection = new SqlConnection(
				"Data Source=CASTLE-PC;Database=DropCreateDB;Integrated Security=True");
			connection.Open(); // open connection . Берет один поток
			var command = connection.CreateCommand();
			command.CommandText = query;

			var reader = command.ExecuteReader(); // объект который читает каждую строку что возвращает SQL
			//от sql приходит 1 result set , в котором может быть несколько строк в зависимости от выборки
			//циклом проходим по всем строкам
			while (reader.Read()) {
				result.Add(CreateOrderModel(reader));
			}

			return result;
			//throw new NotImplementedException();
		}

		private OrderModel CreateOrderModel(SqlDataReader reader)
		{
			var result = new OrderModel();

			result.ID = reader.GetInt32(0);
			result.ID_Order = reader.GetInt32(1);
			result.ID_Profile = reader.GetInt32(2);
			result.State_Detail = reader.GetString(3);
			//2 версия
			//result.ID = reader.GetInt32(GetColumnNumber("ID"));
			//result.ID_Order = reader.GetInt32(GetColumnNumber("ID_Order"));
			//result.ID_Profile = reader.GetInt32(GetColumnNumber("ID_Profile"));
			//result.State_Detail = reader.GetInt32(GetColumnNumber("State_Detail"));
			//3 версия
			//result.ID = reader.GetInt32(GetColumnNumber(GetPropertyName('ID')));

			var modelProperties = GetModelProps(typeof(OrderModel));

			foreach ( var item in modelProperties)
			{
				var propNameInDB = GetPropNameInDB(item);
				var propType = GetPropType(item);
				var value = GetPropValue(reader, propNameInDB, propType);
				item.SetValue(result, value);
			}

			return result;

		}

		private PropertyInfo[] GetModelProps(Type modelType)
		{
			var result = new List<PropertyInfo>();
			foreach (var item in modelType.GetProperties(BindingFlags.Public | BindingFlags.Instance)) // возвращает все свойства set get 
			{
				var att = item.GetCustomAttribute<DBMappingFieldAtribute>();
				if (att != null) result.Add(item);
			}
			return result.ToArray();
		}

		private string GetPropNameInDB(PropertyInfo item)
		{
			var result = item.Name;
			var att = item.GetCustomAttribute<DBMappingFieldAtribute>() as DBMappingFieldAtribute;
			if (att != null & string.IsNullOrEmpty(att.DBFieldName)) return result;
			return result;
		}

		private Type GetPropType(PropertyInfo item)
		{
			return item.PropertyType;
		}

		private Object GetPropValue(SqlDataReader reader, string propNameInDB, Type propType)
		{
			var index = GetColumnNumber(propNameInDB, reader);
			if (propType == typeof(int)) return reader.GetInt32(index);
			throw new Exception("no match");
		}

		private int GetColumnNumber(string columnName, SqlDataReader reader)
		{
			for (int i = 0; i < reader.FieldCount ; i++)
			{
				//if (reader.GetName(i).Equal(columnName)) // как надо
				if (reader.GetName(i).Contains(columnName)) //как я сделал
					return i;
			}

			throw new Exception("no column");
		}
	}
}
