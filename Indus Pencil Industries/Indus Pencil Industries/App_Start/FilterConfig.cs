using System.Web;
using System.Web.Mvc;

namespace Indus_Pencil_Industries
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
