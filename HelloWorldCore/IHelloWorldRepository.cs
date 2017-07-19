using HelloWorldData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore
{
    public interface IHelloWorldRepository
    {
        HelloWorld Print();
    }
}
