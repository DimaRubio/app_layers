using System.Web;
using System.Web.Mvc;

namespace Infopuls_les4_Second
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
