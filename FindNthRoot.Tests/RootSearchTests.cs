using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindNthRoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNthRoot.Tests
{
    [TestClass()]
    public class RootSearchTests
    {
        [TestMethod()]
        public void NewtonMethodTest()
        {
            double expected = 2;

            double actual = RootSearch.NewtonMethod(8, 3, 0.0001);

            Assert.AreEqual(2,actual,0.0001);
        }
    }
}