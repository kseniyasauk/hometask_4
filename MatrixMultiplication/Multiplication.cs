using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    public class Multiplication
    {
        //    public double[][] matrix;
        //    string input = File.ReadAllText(path);
        //    //int numOflines[0]

        //    int i = 0, j = 0;
        //    int[,] result = new int[10, 10];
        //            foreach (var row in input.Split('\n'))
        //            {
        //                j = 0;
        //                foreach (var col in row.Trim().Split(' '))
        //                {
        //                    result[i, j] = int.Parse(col.Trim());
        //                    j++;
        //                }
        //i++;
        //            }

        public void Multiplicate(string[] lines)
        {
            string[] dimension = null;
            for (int i = 0; i < 2; i++)
            {
                dimension[i] = lines[i].Split(',').ToString();
            }
            //string dimensionFirst = lines[0].Split(',').ToString();
            //string dimensionSecond = lines[1].Split(',').ToString();

            foreach (string dim in dimension)
            {
                Int32.Parse(dim);
            }
            
            //int num = Int32.Parse(lines[0]);
        }

        
    }
}
