using System.Web.Mvc;
using Developer.Services.Admin.LogService;
using log4net;

namespace Developer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters, ILog logger)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ExceptionLoggingFilter(logger));
        } 
    }
}