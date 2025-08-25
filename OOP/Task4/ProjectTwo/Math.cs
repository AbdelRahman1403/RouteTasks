using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    internal class Math
    {
        public static int Add(int N1, int N2)
        {
            return N1 + N2;
        }

        public static double Divide(int N1, int N2)
        {
            return N1 / (N2 <= 0 ? 1 : N2);
        }

        public static  int Multiply(int N1, int N2)
        {
            return N1 * N2;
        }

        public static int Subtract(int N1, int N2)
        {
            return N1 - N2;
        }
    }
}
