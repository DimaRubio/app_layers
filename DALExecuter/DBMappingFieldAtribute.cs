using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DALExecuter
{
	class DBMappingFieldAtribute : Attribute
	{
		public string DBFieldName { get; private set; }
		public DBMappingFieldAtribute( string DBFieldName = null) // если в атрибуте не назначаем имя для базе - то берем название Проперти в модели
		{
			this.DBFieldName = DBFieldName;
		}
	}
}
