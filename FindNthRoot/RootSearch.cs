using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNthRoot
{
    public class RootSearch
    {

        //<summary>Сalculate the root of the n-th degree from a number using the Newton method with a given accuracy.</summary>
        public static double NewtonMethod(double number, int powerOfRoot, double accuracy)
        {
            double firstApproach = number/powerOfRoot;
            if (powerOfRoot == 0)
                throw new ArgumentException("0-th root of number doesn't exist.");

            if (number != 0)
            {
                if (powerOfRoot % 2 == 0 && number < 0)
                    throw new ArgumentException("N-th root with even power and negative base doesn't exist.");

                if (accuracy < 0.0 || accuracy >= 1.0)
                    throw new ArgumentException("Accuracy must be greater than 0 and less than 1.");

                while (true)
                {
                    double f = Math.Pow(firstApproach, powerOfRoot) - number;

                    if (Math.Abs(f) < accuracy)
                        break;

                    firstApproach += -f / (powerOfRoot * Math.Pow(firstApproach, powerOfRoot - 1));
                }

                return firstApproach;
            }
            else
                return 0;
        }
    }
}
