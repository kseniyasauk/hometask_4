using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace MatrixConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Manipulations m = new Manipulations();
            

            m.ReadAllSettings();
            m.ReadSetting("file");
        }
    }
}
