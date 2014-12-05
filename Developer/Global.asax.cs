using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using Developer.App_Start;
using Developer.Migrations;
using Developer.Models.EntityModels;
using log4net;
using log4net.Config;

namespace Developer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Bootstrapper.Initialise();

            XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/Web.config")));
            ILog logger = LogManager.GetLogger("Log4NetTest.OtherClass");
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters, logger);
            
            //Database.SetInitializer(new DropCreateDatabaseAlways<ApplicationContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationContext, Configuration>());
            MapperConfig.Register();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["Visited"] = new List<int>();
        }
    }
}
