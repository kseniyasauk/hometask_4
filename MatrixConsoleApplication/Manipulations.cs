using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.IO;

namespace MatrixConsoleApplication
{
    class Manipulations
    {
        //string file = ConfigurationManager.AppSettings["file"];

        public void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        public string[] ReadSetting(string key)
        {
            string[] lines = null;
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";

                lines = File.ReadAllLines(result);
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i].ToString());
                }
                return lines;
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return lines;
        }

        public void ReadFile()
        {
            String input = File.ReadAllText(@"c:\myfile.txt");

            int i = 0, j = 0;
            int[,] result = new int[10, 10];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    result[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            //File.OpenRead();
        }

    }
}
