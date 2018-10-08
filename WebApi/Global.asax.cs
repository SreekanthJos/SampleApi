using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            UnityConfig.RegisterComponents();
            // AutoMapper.Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile>());
            GlobalConfiguration.Configure(WebApiConfig.Register);

        }
    }
}
