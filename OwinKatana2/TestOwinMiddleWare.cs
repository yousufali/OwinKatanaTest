using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin;

namespace OwinKatana2
{
    public class TestOwinMiddleWare
    {
        private Func<IDictionary<string, object>, Task> m_next;

        public TestOwinMiddleWare(Func<IDictionary<string, object>, Task>  next)
        {
            m_next = next;
        }

        public async Task Invoke(IDictionary<string, object> env)
        {
            var context = new OwinContext(env);
            Helper.Write("TestOwinMiddleWare", context.Request.User);
            await m_next(env);
        }
    }
}