using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using KarimiApp.Server.Api;
using KarimiApp.Server.Repository;

namespace KarimiApp.Server.Web
{
    public static class WebApiConfig
    {
        
        public static void Register(HttpConfiguration config)
        {

            UnitOfWork unitOfWork = new UnitOfWork();
            // Web API configuration and services

            // Web API routes
            //config.MapHttpAttributeRoutes();
            MyApiConfig.RegisterHost(config);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

    }
}
