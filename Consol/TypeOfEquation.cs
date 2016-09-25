using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Equations;

namespace Consol
{
    class TypeOfEquation
    {
        public void Choose()
        {
            string coeffs;
            int numOfCoeffs;
            Solving solve = new Solving();
            Manipulations manip = new Manipulations();

            List<double> allCoeffs;

            Console.WriteLine("Input 1 for 'linear' or 2 for 'quadratic'");

            string type = Console.ReadLine();
            
            switch (type)
            {
                case "1":
                    Console.WriteLine("'ax + b = 0': input 'a' and 'b'");
                    numOfCoeffs = 2;
                    allCoeffs = manip.ReadLinesFromConsole(numOfCoeffs);
                    Console.WriteLine("{0:F2}", $"Root: {solve.SolveLinearEquation(allCoeffs)}");
                    break;
                case "2":
                    Console.WriteLine("'ax^2 + bx + c = 0': input 'a', 'b' and 'c'");
                    numOfCoeffs = 3;
                    allCoeffs = manip.ReadLinesFromConsole(numOfCoeffs);
                    Console.WriteLine("{0:F2}", $"Positive root: {solve.SolveQuadraticEquation(allCoeffs, true)}");
                    Console.WriteLine("{0:F2}", $"Negative root: {solve.SolveQuadraticEquation(allCoeffs, false)}");
                    break;
                default:
                    Console.WriteLine("error");
                    Choose();
                    break;
            }
        }

        
    }
}
