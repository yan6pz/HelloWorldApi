using HelloWorldData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore
{
    public class HelloWorldRepository : BaseRepository<HelloWorld>, IHelloWorldRepository
    {

        public HelloWorldRepository(HelloWorldContext context)
         : base(context)
        { }

        public HelloWorld Print()
        {
            var result = this.Context.HelloWorld.FirstOrDefault();
            return result;
        }
    }
}
