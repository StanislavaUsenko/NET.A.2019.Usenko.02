using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextBiggerNumber
{
    public class NextNumber
    {
        static string time = null;

        //<summary>Takes a positive integer and returns the nearest largest integer consisting of the digits of the original number, and - 1 (null) if such a number does not exist.</summary>
        public static int? FindNumber(int number)
        {
            if (number <= 0)
                return null;

            int[] arrayOfNumber = new int[number.ToString().Length];

            for (int i = 0; i < arrayOfNumber.Length; i++)
                arrayOfNumber[i] = int.Parse(number.ToString()[i].ToString());

            var timeForFind = System.Diagnostics.Stopwatch.StartNew();

            if (CheckOnBiggerNumber(arrayOfNumber))
                return null;

            for (int i = arrayOfNumber.Length - 1; i >= 0; i--)
                if (arrayOfNumber[i] > arrayOfNumber[i - 1])
                {
                    Swap(ref arrayOfNumber[i], ref arrayOfNumber[i - 1]);
                    break;
                }

            string newNumber = null;
            for (int i = 0; i < arrayOfNumber.Length; i++)
                newNumber += arrayOfNumber[i].ToString();

            timeForFind.Stop();

            time = timeForFind.Elapsed.ToString();
            

            return int.Parse(newNumber);
        }

        //<summary>Returns execution time</summary>
        public static string ReturnTime ()
        {
            if (time != null)
                return time;
            else
                return "Method FindNumber don't find a number";
        }

        //<summary>Looks for a big number</summary>
        private static bool CheckOnBiggerNumber(int[] arrayOfNumber)
        {
            int counter = 0;

            for (int i = 0; i < arrayOfNumber.Length - 1; i++)
                if (arrayOfNumber[i] >= arrayOfNumber[i + 1])
                    counter++;

            if (counter == arrayOfNumber.Length - 1)
                return true;

            return false;
        }
        //<summary>Swaps values</summary>
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
