using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public class Vertex : IComparable<Vertex>
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

        public int CompareTo(Vertex? other)
        {
            if (Coordinates.Y.CompareTo(other.Coordinates.Y) == 0) return Coordinates.X.CompareTo(other.Coordinates.X);
            return coordinates.Y.CompareTo(other.Coordinates.Y);
        }
    }

    public class VertexCoordinates
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

        public static NormalVector operator -(VertexCoordinates u, VertexCoordinates v)
        {
            return new NormalVector(u.x - v.x, u.y - v.y, u.z - v.z);
        }
          
    }

    public class NormalVector
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

        public double Product(NormalVector nV)
        {
            NormalVector vU = this.GetVersor();
            NormalVector vV = nV.GetVersor();

            return vU.xn * vV.xn + vU.yn * vV.yn + vU.zn * vV.zn;
        }

        public double Cosinus(NormalVector nV)
        {
            double product = this.Product(nV);
            return product < 0 ? 0 : product;
        }

        public static NormalVector operator*(double d, NormalVector v)
        {
            return new NormalVector(v.xn * d, v.yn * d, v.zn * d);
        }

        public static NormalVector operator-(NormalVector u, NormalVector v)
        {
            return new NormalVector(u.xn - v.xn, u.yn - v.yn, u.zn - v.zn);
        }
    }
}
