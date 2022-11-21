using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    public class Vertex // klasa wierzcholek przechowywujaca wirtualne wspolrzedne i wektory wlasne i pozwalajaca skalowac je na wspolrzedne ekranowe
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

        public Point ToPoint(int size) // skalowanie do wspolrzednych ekranowych dla okna rozmiaru size
        {
            int range = size / 2;
            return new Point((int)(50 + coordinates.X * range + range), (int)(50 + coordinates.Y * range + range));
        }
    }

    public class VertexCoordinates // wspolrzedne wirtualne wierzcholka, roznica wspolrzednych to wektor miedzy punktami
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

    public class NormalVector // wektor normalny
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
        
        public NormalVector GetVersor() // skalowanie dlugosci do 1
        {
            return new NormalVector(xn / Length, yn / Length, zn / Length);
        }

        public double Product(NormalVector nV) // iloczyn skalarny z drugim wektorem
        {
            NormalVector vU = this.GetVersor();
            NormalVector vV = nV.GetVersor();

            return vU.xn * vV.xn + vU.yn * vV.yn + vU.zn * vV.zn;
        }

        public NormalVector VectorProduct(NormalVector nV) // ilcozyn wektorowy z drugim wektorem
        {
            return new NormalVector(this.yn * nV.zn - this.zn * nV.yn, this.zn * nV.xn - this.xn * nV.zn, this.xn * nV.yn - this.yn * nV.xn);
        }

        public double Cosinus(NormalVector nV)
        {
            double product = this.Product(nV);
            return product < 0 ? 0 : product;
        }

        public static NormalVector operator*(double d, NormalVector v) // mnozenie przez skalar
        {
            return new NormalVector(v.xn * d, v.yn * d, v.zn * d);
        }

        public static NormalVector operator-(NormalVector u, NormalVector v)
        {
            return new NormalVector(u.xn - v.xn, u.yn - v.yn, u.zn - v.zn);
        }

        

        public NormalVector Modify(NormalVector nTexture) // modyfikacja na podstawie mapy wektorow normalnych
        {
            NormalVector B = this.VectorProduct(Triangle.oo1).GetVersor();
            if (xn == 0 && yn == 0 && zn == 1) B = new NormalVector(0, 1, 0);
            NormalVector T = B.VectorProduct(this).GetVersor();
            NormalVector[] matrix = new NormalVector[] { T, B, this };
            return Functions.Multiply(matrix, nTexture);
        }

    }
}
