using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using HelloWorldCore;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class HelloWorldServiceTest
    {
        [TestMethod]
        public void PrintPositiveTest()
        {
            var repo = new Mock<IHelloWorldRepository>();
            repo.Setup(x => x.Print()).Returns(new HelloWorldData.HelloWorld() {Value= "Hello World" });

            var result = repo.Object.Print();
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Value, "Hello World");
        }

        [TestMethod]
        public void PrintNullTest()
        {
            var repo = new Mock<IHelloWorldRepository>();
            repo.Setup(x => x.Print()).Returns(default(HelloWorldData.HelloWorld));

            var result = repo.Object.Print();
            Assert.IsNull(result);
        }
    }
}
