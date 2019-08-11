using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterDigit
{
    public class Filtr
    {

        //<summary>Accepts a list of integers and filters the list so that only numbers containing the given digit remain on the output.</summary>
        public static List<int> NumberFiltering(List<int> listOfNumbers, int digitInclude)
        {
            var digitArrays = new Dictionary<int,int[]>();
            foreach( var number in listOfNumbers)
                digitArrays.Add(number,new int[number.ToString().Length]);

            foreach (var digits in digitArrays)
                for (int i = 0; i < digits.Value.Length; i++)
                     digits.Value[i] = int.Parse(digits.Key.ToString()[i].ToString());

            List<int> temp = new List<int>();

            foreach (var digits in digitArrays)
                for (int i = 0; i < digits.Value.Length; i++)
                    if (digits.Value[i] == digitInclude)
                    {
                        temp.Add(Combine(digits.Value));
                        break;
                    }

            return temp;
        }


        //<summary>Comdine array of digits</summary>
        private static int Combine(int[] arrayOfNumber)
        {
            string number = null;
            for (int i = 0; i < arrayOfNumber.Length; i++)
                number += arrayOfNumber[i].ToString();

            return int.Parse(number);
        }
    }
}
