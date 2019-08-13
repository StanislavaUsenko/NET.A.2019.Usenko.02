using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilterDigit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDigit.Tests
{
    [TestClass()]
    public class FiltrTests
    {
        [TestMethod()]
        public void NumberFilteringTest()
        {
            List<int> listOfNumbers = new List<int>(){51, 14, 5};
            int digitInclude = 1;
            List<int> expected = new List<int>() {51, 14};

            List <int> actual = Filtr.NumberFiltering(listOfNumbers, digitInclude);

            Assert.ReferenceEquals(expected, actual);
        }
    }
}