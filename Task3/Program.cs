using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_Lib;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix A = new Matrix();
            Matrix B = new Matrix();
            Matrix C = new Matrix();
            InitMatrix(A, B, ConfigurationReading.ReadSetting("file"));
            C = A * B;
            Console.WriteLine(C);
            Console.ReadKey();
        }

        static void InitMatrix(Matrix A, Matrix B, string pathToInputDataFile)
        {
            string illegalParametres = "Параметры неправильного типа";
            string illegalCountOfElemets = "Различное количество чисел в одной строке";
            try
            {
                List<string> stringsA = File.ReadLines(pathToInputDataFile).TakeWhile(c => !c.Equals("")).ToList();
                int m1 = stringsA.Count();
                int n1 = stringsA[0].Split(' ').ToArray().Length;
                double[,] tempArrayA = new double[m1, n1];
                for (int i = 0; i < m1; i++)
                {
                    string[] elements = stringsA[i].Split(' ').ToArray();
                    if (elements.Length != n1)
                    {
                        throw new System.ArgumentException(illegalCountOfElemets);
                    }
                    for (int j = 0; j < n1; j++)
                    {
                        double temp = 0;
                        if (double.TryParse(elements[j], out temp))
                        {
                            tempArrayA[i, j] = temp;
                        }
                        else
                        {
                            throw new System.ArgumentException(illegalParametres);
                        }
                    }
                }

                List<string> stringsB = File.ReadLines(pathToInputDataFile).Skip(m1 + 2).ToList();
                int m2 = stringsB.Count();
                int n2 = stringsB[0].Split(' ').ToArray().Length;
                double[,] tempArrayB = new double[m2, n2];
                for (int i = 0; i < m2; i++)
                {
                    string[] elements = stringsB[i].Split(' ').ToArray();
                    if (elements.Length != n2)
                    {
                        throw new System.ArgumentException(illegalCountOfElemets);
                    }
                    for (int j = 0; j < n2; j++)
                    {
                        double temp = 0;
                        if (double.TryParse(elements[j], out temp))
                        {
                            tempArrayB[i, j] = temp;
                        }
                        else
                        {
                            throw new System.ArgumentException(illegalParametres);
                        }
                    }
                }
                A.InitMatrixByArray(tempArrayA);
                B.InitMatrixByArray(tempArrayB);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
