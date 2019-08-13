using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindNextBiggerNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextBiggerNumber.Tests
{
    [TestClass()]
    public class NextNumberTests
    {
        [TestMethod()]
        public void FindNumberTest()
        {
            int number = 234;
            int expected = 243;

            int? actual = NextNumber.FindNumber(number);

            Assert.AreEqual(expected,actual);
        }
    }
}