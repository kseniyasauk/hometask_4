using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2_4
{
    class Square
    {
        public double SurfaceSquare { get; private set; } = 0.0;
        double RectangleSquare = 4.5;

        public Square(double surfaceSquare)
        {
            this.SurfaceSquare = surfaceSquare;

        }

        public int GetCount() {
            int num = Convert.ToInt32(this.SurfaceSquare / RectangleSquare);
            return num;
        }
    }
}
