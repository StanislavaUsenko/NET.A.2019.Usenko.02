using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindNextBiggerNumber;
using InsertNumber;
using FindNthRoot;
using FilterDigit;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            List <int> test = Filtr.NumberFiltering(new List<int>{15,464,48,1},0);

            foreach(var t in test)
            {
                Console.WriteLine(t);
            }

            Console.ReadLine();
        }
    }
}
