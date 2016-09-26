using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            long fact = Recursion.GetFactorial(4);
            long fib = Recursion.GetFibonachi(4);
            Console.WriteLine($"Factorial: {fact}, Fibonachi: {fib}", fact, fib);
        }
    }
}
