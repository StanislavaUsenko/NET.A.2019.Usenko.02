using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNumber
{
    public class InsertingNumber
    {
        //<summary>Insert bits from the jth to the i-th bit of one number into another</summary>
        public static int InsertNumber(int first, int second, int i, int j)
        {
            if (i < 0 || j < 0 || i > 31 || j > 31)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (i > j)
            {
                throw new ArgumentException();
            }

            int medium = ((2 << (j - i)) - 1) << i;
            return (first & ~medium) | ((second << i) & medium);
        }
    }
}
