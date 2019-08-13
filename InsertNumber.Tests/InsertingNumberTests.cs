using Microsoft.VisualStudio.TestTools.UnitTesting;
using InsertNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNumber.Tests
{
    [TestClass()]
    public class InsertingNumberTests
    {
        [TestMethod()]
        public void InsertNumberTest()
        {
            int first = 15;
            int second = 15;
            int i = 0;
            int j = 0;
            int expected = 15;

            int actual = InsertingNumber.InsertNumber(first, second, i, j);

            Assert.AreEqual(expected,actual);
        }
    }
}