using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using HelloWorldData;
using System.Data.Entity;
using System.Linq;

namespace HelloWorldCore.Tests
{
    [TestClass]
    public class HelloWorldRepositoryTests
    {
        [TestMethod]
        public void GetHelloWorldObjectFromContext()
        {
            var repo = new HelloWorldContext();
            repo.HelloWorld.Add(new HelloWorld { Value = "Hello World" });
            //repo.SetupGet(x => x.HelloWorld).Returns();

            var result = repo.HelloWorld.Local.FirstOrDefault();
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Value, "Hello World");
        }
    }
}
