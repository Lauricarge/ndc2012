﻿using System;
using System.Web;
using System.Web.Http;

namespace NdcDemo
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            WebApiConfig.Initialize(GlobalConfiguration.Configuration);
        }
    }
}