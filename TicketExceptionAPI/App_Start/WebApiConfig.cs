﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TicketExceptionAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Turned off any security for now --add oauth later
      //      config.Filters.Add(new APIService.BasicAuthenticationAttribute());
        }
    }
}
