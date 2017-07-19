using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Client;
using Moq;

namespace HelloWorldClient.Tests
{
    [TestClass]
    public class HelloWorldManagerTests
    {

        [TestMethod]
        public void GetHelloWorld()
        {
            var manager = new Mock<IHelloWorldManager>();
            manager.Setup(x => x.GetHelloWorldAsync()).ReturnsAsync("Hello World");

            var result= manager.Object.GetHelloWorldAsync().Result;
            Assert.AreEqual(result, "Hello World");
        }
    }
}
