using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpConcepts.Classes.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpConcepts.Tests.Examples
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestCircleCircumference()
        {
            var circle = new Circle(12);
            Assert.AreEqual(75.408, circle.Circumference);
        }

        [TestMethod]
        public void TestCircleArea()
        {
            var circle = new Circle(10);
            Assert.AreEqual(314.2, circle.Area);
        }
    }
}

