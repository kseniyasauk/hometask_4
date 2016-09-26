using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(3.1,7.0);
            Point point2 = new Point(5.1, 7.0);
            Console.WriteLine(point1);
            Console.WriteLine(point1.Equals(point2));
            
        }
    }
}
