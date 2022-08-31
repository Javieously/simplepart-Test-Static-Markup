using System.Web;
using System.Web.Mvc;

namespace simplepart_Test_Static_Markup
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
