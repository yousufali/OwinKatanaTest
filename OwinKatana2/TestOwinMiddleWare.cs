using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin;

namespace OwinKatana2
{
    public class TestOwinMiddleWare
    {
        private readonly Func<IDictionary<string, object>, Task> m_next;

        public TestOwinMiddleWare(Func<IDictionary<string, object>, Task>  next)
        {
            m_next = next;
        }

        public async Task Invoke(IDictionary<string, object> env)
        {
            var context = new OwinContext(env);
            //authentication code comes here
            context.Request.User = new GenericPrincipal(new GenericIdentity("yousuf"),new string[] {});            
            Helper.Write("TestOwinMiddleWare", context.Request.User);
            await m_next(env);
        }
    }
}