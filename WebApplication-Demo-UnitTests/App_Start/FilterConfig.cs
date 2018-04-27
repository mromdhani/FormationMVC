using System.Web;
using System.Web.Mvc;

namespace WebApplication_Demo_UnitTests
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
