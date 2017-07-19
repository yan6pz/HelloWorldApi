using BusinessLayer.Models;
using HelloWorldCore;
using HelloWorldData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HelloWorldService
    {
        public IHelloWorldRepository HelloWorldRepository { get; set; }

        public HelloWorldService()
        {
            this.HelloWorldRepository = new HelloWorldRepository(new HelloWorldContext());
        }

        public HelloWorldModel GetHelloWorld()
        {
            var dataEntity = this.HelloWorldRepository.Print();

            return new HelloWorldModel { Value = dataEntity?.Value??"Hello World" };
        }
    }
}
