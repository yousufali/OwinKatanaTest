using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Web;

namespace OwinKatana2
{
    public class HttpModule : IHttpModule
    {

        public void Init(HttpApplication context)
        {
            context.BeginRequest += content_BeginRequest;
        }

        void content_BeginRequest(object sender, EventArgs e)
        {
            Helper.Write("HttpModule", HttpContext.Current.User);
        }

        public void Dispose()
        {
        }
    }

    public class Helper
    {
        public static void Write(string caller, IPrincipal principal)
        {
            Debug.WriteLine("------" + caller + "-------");
            if (principal?.Identity == null || !principal.Identity.IsAuthenticated)
            {
                Debug.WriteLine("Anonymous User");
            }
            else
            {
                Debug.WriteLine("User : " + principal.Identity.Name);
            }
            Debug.WriteLine("\n");
        }
    }

}