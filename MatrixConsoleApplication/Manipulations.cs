using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.IO;

namespace MatrixConsoleApplication
{
    public class Manipulations
    {
        static string appSettings = ConfigurationManager.AppSettings["file"];

        public static string[] ReadFromFile()
        {
            
            string[] file = File.ReadAllLines(appSettings).Skip(2).ToArray();

            return file;
        }

        public static List<int> ReadFromFileDimensions()
        {
            List<int> numbers = null; 
            var dimensions = File.ReadAllLines(appSettings).Take(2).ToArray();
            foreach (string dimension in dimensions)
            {
                var dim = dimension.Split(',');
                for (int i = 0; i < dim.Length; i++)
                {
                   numbers[i] = Int32.Parse(dim[i]);
                }
            }

            return numbers;
        }

        public void Start()
        {
            List<int> dim = ReadFromFileDimensions();
            Matrix m1 = new Matrix(dim[0],dim[1]);
            m1.GetMatrix();
            Matrix m2 = new Matrix(dim[2], dim[3]);
            m2.GetMatrix();
            MatrixMultiplication.Multiplication.
        }
    }
}
