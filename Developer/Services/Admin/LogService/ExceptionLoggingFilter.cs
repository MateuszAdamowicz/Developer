using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Filters;
using log4net;
using System.Web.Mvc;
using ExceptionContext = System.Web.Mvc.ExceptionContext;
using IExceptionFilter = System.Web.Mvc.IExceptionFilter;

namespace Developer.Services.Admin.LogService
{
    public class ExceptionLoggingFilter: IExceptionFilter
    {
        private readonly ILog _logger;
        public ExceptionLoggingFilter(ILog logger)
        {
            _logger = logger;
        }

        public virtual void OnException(ExceptionContext filterContext)
        {
            _logger.Error(filterContext.Exception);
        }
    }
}