using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldRevisited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldRevisited.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CreateMessageTest()
        {
            Assert.AreEqual("Hello World Revisited!", Program.CreateMessage());
        }
    }
}