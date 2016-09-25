using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equations
{
    public class Solving
    {
        
        public double SolveLinearEquation(List<double> coeffs)
        {
            double a = coeffs[0];
            double b = coeffs[1];
            if (a == 0)
            {
                return double.NaN;
            }
            var root = (-b)/a;
            return root;
        }

        public double SolveQuadraticEquation(List<double> coeffs, bool pos)
        {
            double a = coeffs[0];
            double b = coeffs[1];
            double c = coeffs[2];
            var preRoot = b * b - 4 * a * c;
            if (preRoot < 0)
            {
                return double.NaN;
            }
            else
            {
                var sgn = pos ? 1.0 : -1.0;
                return (sgn * Math.Sqrt(preRoot) - b) / (2.0 * a);
            }
        }
    }
}
