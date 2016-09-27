using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixConsoleApplication
{
    public class Matrix
    {
        public int Row { get; private set; } = 0;
        public int Column { get; private set; } = 0;
        public


        public Matrix(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }

        public int[,] GetMatrix()
        {
            return new int[this.Row,this.Column]; 
        }
    }
}
