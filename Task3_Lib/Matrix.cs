using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Lib
{
    public class Matrix
    {
        double[,] Matr { get; set; }
        int m { get; set; }
        int n { get; set; }

        public Matrix(double[,] M)
        {
            InitMatrixByArray(M);
        }

        public Matrix(int a, int b)
        {
            this.Matr = new double[a, b];
            this.m = a;
            this.n = b;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    this.Matr[i, j] = 0;
                }
            }
        }

        public Matrix() { }

        public void InitMatrixByArray(double[,] M)
        {
            this.Matr = new double[M.GetLength(0), M.GetLength(1)];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    this.Matr[i, j] = M[i, j];
                }
            }
            this.m = M.GetLength(0);
            this.n = M.GetLength(1);
        }

        //C = A*B
        public static Matrix operator *(Matrix A, Matrix B)
        {
            if (A.n != B.m) //Проверка, можно ли их перемножать
                throw new ArgumentException("Не совпадают размерности матриц");
            Matrix C = new Matrix(A.m, B.n); //Столько же строк, сколько в А; столько столбцов, сколько в B 
            for (int i = 0; i < A.m; ++i)
            {
                for (int j = 0; j < B.n; ++j)
                {
                    for (int k = 0; k < A.n; ++k)
                    {
                        C.Matr[i, j] += A.Matr[i, k] * B.Matr[k, j]; //Собираем сумму произведений
                    }
                }
            }
            return C;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < this.m; i++)
            {
                for (int j = 0; j < this.n; j++)
                {
                    str.Append(this.Matr[i, j] + "\t");
                }
                str.Append("\n");
            }
            return str.ToString();
        }



    }
}
