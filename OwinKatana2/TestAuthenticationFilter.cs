using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace OwinKatana2
{
    public class TestAuthenticationFilter : Attribute,IAuthenticationFilter         
    {
        public bool AllowMultiple => false;

        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            Helper.Write("TestAuthenticationFilter", context.ActionContext.RequestContext.Principal);
            //throw new NotImplementedException();
        }

        public async Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
        }
    }
}