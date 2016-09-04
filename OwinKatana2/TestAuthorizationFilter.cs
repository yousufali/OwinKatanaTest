using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace OwinKatana2
{
    public class TestAuthorizationFilter :AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            Helper.Write("TestAuthorizationFilter", actionContext.RequestContext.Principal);
            return true;
        }
    }
}