using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    internal class Vertex
    {
        VertexCoordinates coordinates;
        NormalVector vector;

        const int gap = 50;

        public VertexCoordinates Coordinates { get { return coordinates; } }
        public NormalVector Normal { get { return vector; } }

        public Vertex(VertexCoordinates coordinates, NormalVector vector)
        {
            this.coordinates = coordinates;
            this.vector = vector;
        }

        public Point ToPoint(int size)
        {
            int range = size / 2;
            return new Point((int)(50 + coordinates.X * range + range), (int)(50 + coordinates.Y * range + range));
        }
    }

    internal class VertexCoordinates
    {
        double x;
        double y;
        double z;

        public double X { get { return x; } }
        public double Y { get { return y; } }
        public double Z { get { return z; } }

        public VertexCoordinates(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    internal class NormalVector
    {
        double xn;
        double yn;
        double zn;

        public double Xn { get { return xn; } }
        public double Yn { get { return yn; } }
        public double Zn { get { return zn; } }
        public double Length { get { return Math.Sqrt(xn * xn + yn * yn + zn * zn); } }
        public NormalVector(double xn, double yn, double zn)
        {
            this.xn = xn;
            this.yn = yn;
            this.zn = zn;
        }
        
        public NormalVector GetVersor()
        {
            return new NormalVector(xn / Length, yn / Length, zn / Length);
        }

    }
}
