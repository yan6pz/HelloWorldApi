using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldApi.Controllers
{
    public class HelloWorldController : BaseApiController
    {
        [Route("helloWorld")]
        public string Get()
        {
            var model = base.HelloWorldService.GetHelloWorld();
            return model.Value;
        }

    }
}
