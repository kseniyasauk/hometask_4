using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Consol
{
    class Manipulations
    {
        public List<double> ListOfLines { get; private set; } = new List<double>();
        public int ResultIntNum { get; private set; } = 0;
        public double ResultDoubleNum { get; private set; } = 0;
        public List<int> IntNums { get; private set; } = new List<int>();
        public List<double> DoubleNums { get; private set; } = new List<double>();

        
        public List<double> ReadLinesFromConsole(int numOfCoeffs)
        {
            try
            {
                for (int i = 0; i < numOfCoeffs; i++)
                {
                    string line = Console.ReadLine();
                    if (!String.IsNullOrEmpty(line))
                    {
                        line = line.Replace(",", ".");
                    }
                    double intNumCoeff;
                    if (double.TryParse(line, out intNumCoeff))
                    {
                        
                        ListOfLines.Add(intNumCoeff);
                        Console.WriteLine(intNumCoeff);
                    } else
                    {
                        string message = "Enter correct coefficients!";
                        Console.WriteLine(message);
                        Logs logs = new Logs();
                        logs.AddToList(message);
                    }
                }
                
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.ToString());
            }

            //Console.WriteLine(ListOfLines.ToString());
            return ListOfLines;
        }
    }
}
