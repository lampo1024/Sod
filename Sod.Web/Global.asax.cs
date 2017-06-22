using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.WebPages;
using Sod.Web.Mapper;
using Sod.Web.Util;

namespace Sod.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Device detector
            DisplayModeProvider.Instance.Modes.Insert(0, new CustomMobileDisplayMode());

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Register AutoMapper
            RegisterAutoMapper();
        }

        /// <summary>
        /// register automapper
        /// </summary>
        private static void RegisterAutoMapper()
        {
            new AutoMapperStartupTask().Execute();
        }

        /// <summary>
        /// set response header with apache
        /// </summary>
        protected void Application_PreSendRequestHeaders()
        {
            Response.Headers.Set("Server", "Apache");
        }

        /// <summary>
        /// handle application error
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event argument</param>
        protected void Application_Error(object sender, EventArgs e)
        {
            //var exception = Server.GetLastError();
            //var message = exception.ToString();
            
            //Server.ClearError();
            //Response.Redirect("/error");
        }
    }
}
