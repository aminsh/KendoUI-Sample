﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;

namespace Using_KendoUI
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var config = GlobalConfiguration.Configuration;

            config.Routes.MapHttpRoute(
               name: "WebApiDefault",
               routeTemplate: "api/{controller}/{action}/{id}",
               defaults: new { action = RouteParameter.Optional, id = RouteParameter.Optional }
               );
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}