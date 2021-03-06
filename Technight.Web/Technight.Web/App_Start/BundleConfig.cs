﻿using System.Web;
using System.Web.Optimization;

namespace Technight.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /*bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            */
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            /*bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            */
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.js"));


            
            bundles.Add(new ScriptBundle("~/ng").Include(                
                    "~/Scripts/angular.min.js"
                    ,"~/Scripts/angular-route.min.js"
                    ,"~/Scripts/angular-cookies.min.js"
                    ,"~/Scripts/angular-santize.min.js"
                    , "~/Scripts/ui-bootstrap-tpls-0.12.0.min.js"
                    ));

            bundles.Add(new ScriptBundle("~/app").IncludeDirectory("~/Scripts/ng", "*.js", true));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
