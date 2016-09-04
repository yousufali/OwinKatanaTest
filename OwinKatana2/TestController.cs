using System.Web.Http;

namespace OwinKatana2
{
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            Helper.Write("TestController", User);
            return Ok();
        }
    }
}