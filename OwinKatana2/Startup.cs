using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Owin;

namespace OwinKatana2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            configuration.Routes.MapHttpRoute(
                "default", "api/{controller}");

            app.Use(typeof(TestOwinMiddleWare));
            configuration.Filters.Add(new TestAuthenticationFilter());
            configuration.Filters.Add(new TestAuthorizationFilter());
            app.UseWebApi(configuration);
        }
    }
}