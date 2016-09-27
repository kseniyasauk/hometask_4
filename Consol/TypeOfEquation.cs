using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Equations;
using System.Globalization;

namespace Consol
{
    class TypeOfEquation
    {
        public void Choose()
        {
            Solving solve = new Solving();
            Manipulations manip = new Manipulations();
            Logs logs = new Consol.Logs();

            List<double> allCoeffs = new List<double>();

            Console.WriteLine("Input 1 for 'linear' or 2 for 'quadratic'");

            string type = Console.ReadLine();
            
            switch (type)
            {
                case "1":
                    Console.WriteLine("'ax + b = 0': input 'a' and 'b'");
                    logs.AddToList(DateTime.Now + " " + "Type: linear");

                    double a = manip.ReadCoef("a");
                    double b = manip.ReadCoef("b");

                    allCoeffs.Add(a);
                    allCoeffs.Add(b);

                    Console.WriteLine( $"Root: {solve.SolveLinearEquation(allCoeffs).ToString("F", CultureInfo.InvariantCulture)}");

                    logs.AddToList(DateTime.Now + " " + solve.SolveLinearEquation(allCoeffs));
                    logs.PrintLog();

                    break;
                case "2":
                    Console.WriteLine("'ax^2 + bx + c = 0': input 'a', 'b' and 'c'");
                    logs.AddToList(DateTime.Now + " " + "Type: quadratic");

                    a = manip.ReadCoef("a");
                    b = manip.ReadCoef("b");
                    double c = manip.ReadCoef("c");

                    allCoeffs.Add(a);
                    allCoeffs.Add(b);
                    allCoeffs.Add(c);

                    Console.WriteLine($"Root 1: {solve.SolveQuadraticEquation(allCoeffs, true).ToString("F", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"Root 2: {solve.SolveQuadraticEquation(allCoeffs, false).ToString("F", CultureInfo.InvariantCulture)}");

                    logs.AddToList(DateTime.Now + " " + solve.SolveQuadraticEquation(allCoeffs, true) + " " + solve.SolveQuadraticEquation(allCoeffs, false));
                    logs.PrintLog();

                    break;
                default:
                    Console.WriteLine("error");

                    logs.AddToList(DateTime.Now + " " + "Uncorrect type");

                    Choose();

                    break;
            }
        }
        

    }
}
