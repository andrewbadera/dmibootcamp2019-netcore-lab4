using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace dotnetcore_lab4_aspnetmvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AppDomain ad = AppDomain.CreateDomain("HelloWorld Domain");
            //TODO Replace this path with the path on your machine
            ad.ExecuteAssembly(@"C:\Users\abadera\source\repos\dotnetcore-lab4\dotnetcore-lab4-aspnetmvc\static\ConsoleApp1.exe");
        }
    }
}
