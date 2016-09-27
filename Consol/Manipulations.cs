using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Consol
{
    public class Manipulations
    {
        public double ReadCoef(string coef)
        {
            Logs logs = new Logs();

            double num = 0;
            do
            {
                Console.WriteLine($"Input {coef} :");
                string str = Console.ReadLine();
                if (Double.TryParse(str, out num))
                {
                    break;
                }
                else
                {
                    string message = "There is no number! Try to enter again!";
                    Console.WriteLine(message);

                    logs.AddToList(message);

                    continue;
                }
            } while (true);
            return num;
        }
    }
}
