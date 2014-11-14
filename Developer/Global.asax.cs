using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using Developer.Models.EntityModels;

namespace Developer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Bootstrapper.Initialise();
            Database.SetInitializer(new DropCreateDatabaseAlways<ApplicationContext>());
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
