using Microsoft.VisualStudio.TestTools.UnitTesting;
using add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add.Tests
{
    [TestClass()]
    public class programTests
    {
        [TestMethod()]
        public void sumTest()
        {

            program b = new program();

            Assert.AreEqual(4, b.sum(2, 2));
        }
    }
}