using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Developer
{
    public class BundleConfig
    {
         public static void RegisterBundles(BundleCollection bundles)
         {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-ng-grid.js",
                        "~/Scripts/angular-resource.js",
                        "~/Scripts/angular-route.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Scripts/app/app.js"
                        //"~/Scripts/app/services.js",
                        //"~/Scripts/app/directives.js",
                        //"~/Scripts/app/house.js",
                        //"~/Scripts/app/flat.js",
                        //"~/Scripts/app/land.js"
                        ));
         }
    }
}