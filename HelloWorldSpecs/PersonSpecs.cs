using System;
using System.Dom;
using System.Html;
using HelloWorld;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldSpecs
{
    [TestClass]
    public class PersonSpecs
    {
        [TestMethod]
        public void Assign_Name()
        {
            var p = new Person();
            p.Name = "Mac Donal";

            Assert.AreEqual("Mac Donal",p.Name);
        }

        [TestMethod]
        public void Greeting()
        {
            var p = new Person() {Name = "BBQ"};
            var p2 = new Person() {Name = "KFC"};

            var msg = p.Greeting(p2);

            Assert.AreEqual("Hello KFC", msg);
        }
    }
}
