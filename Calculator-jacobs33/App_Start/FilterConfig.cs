using System.Web;
using System.Web.Mvc;

namespace Calculator_jacobs33
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
