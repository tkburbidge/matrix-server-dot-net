using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Matrix.Client.App_Start
{
    public class ApiRouteConfig
    {
        public const string RoutePrefix = "_matrix/client/r0";

        public static void RegisterRoutes(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes(); 


            //config.routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "_matrix/{controller}/{action}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}