using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    internal class Functions
    {
        public static NormalVector Multiply(NormalVector[] matrix, NormalVector vector) // mnozenie macierzy 3x3 przez wektor
        {
            double xn = matrix[0].Xn * vector.Xn + matrix[1].Xn * vector.Yn + matrix[2].Xn * vector.Zn;
            double yn = matrix[0].Yn * vector.Xn + matrix[1].Yn * vector.Yn + matrix[2].Yn * vector.Zn;
            double zn = matrix[0].Zn * vector.Xn + matrix[1].Zn * vector.Yn + matrix[2].Zn * vector.Zn;
            return new NormalVector(xn, yn, zn);
        }
    }
}
