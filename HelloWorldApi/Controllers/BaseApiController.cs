using BusinessLayer;
using System.Web.Http;

namespace HelloWorldApi.Controllers
{
    public class BaseApiController : ApiController
    {
        public HelloWorldService HelloWorldService { get; set; }
        public BaseApiController()
        {
            HelloWorldService = new HelloWorldService();
        }
    }
}
