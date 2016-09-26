using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2_1
{
    static class  Recursion
    {
        static public int GetFactorial(int n) {
            if (n == 0)
            {
                return 1;
            }
            return n * GetFactorial(n - 1);
        }

        static public int GetFibonachi(int n)
        {
            if (n <= 1)
                return 1;
            return GetFibonachi(n - 1) + GetFibonachi(n - 2);
        }
    }
}
