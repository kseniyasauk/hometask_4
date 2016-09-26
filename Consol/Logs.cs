using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol
{
    class Logs
    {
        public List<string> LogList { get; private set; } = new List<string>();
        const string path = @"D:\ht4\logs.txt";
        

        public void AddToList(string log)
        {
            this.LogList.Add(DateTime.Now +" "+ log + " " + "\r\n");
        }

        public void PrintLog()
        {
            for (int i = 0; i < this.LogList.Count(); i++)
            {
                File.AppendAllText(path, this.LogList[i]);

            }


        }
    }
}
