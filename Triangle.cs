using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    internal class Triangle
    {
        Vertex a;
        Vertex b;
        Vertex c;

        SolidBrush brush;

        public Vertex A { get { return a; } }
        public Vertex B { get { return b; } }
        public Vertex C { get { return c; } }


        public Triangle(Vertex[] vertices)
        {
            a = vertices[0];
            b = vertices[1];
            c = vertices[2];
            brush = new SolidBrush(Color.White);
        }


        public Vertex this[int i]
        {
            get {
                switch (i%3)
                {
                    case 0: return a;
                    case 1: return b;
                    case 2: return c;
                    default: return null;
                }
            }
        }

        public int this[Vertex v]
        {
            get
            {
                if (v == a) return 0;
                if (v == b) return 1;
                return 2;
            }
        }

        public int IndexOf(Vertex v)
        {
            return this[v];
        }

        public void PaintTriangle(int size, Graphics g, SimulationParameters simulationParameters)
        {
            List<Vertex> vertices = new List<Vertex>() { a, b, c };
            vertices.Sort();
            int[] indices = vertices.Select(v => this[v]).ToArray() ;

            List<ActiveEdge> AET = new List<ActiveEdge>();
            int y = this[indices[0]].ToPoint(size).Y;

            int k = 0;

            Point curr;
            Point prev;
            Point next;

            curr = this[indices[k]].ToPoint(size);

            Color colorA = CalculateColor(simulationParameters, this[0]);
            Color colorB = CalculateColor(simulationParameters, this[1]);
            Color colorC = CalculateColor(simulationParameters, this[2]);


            while (y != this[indices[2]].ToPoint(size).Y)
            {
                while (y == curr.Y)
                {
                    Vertex d1 = this[indices[k]];
                    int d2 = this[d1];
                    Vertex d3 = this[d2 + 3 - 1];

                    Point pa = a.ToPoint(size);
                    Point pb = b.ToPoint(size);
                    Point pc = c.ToPoint(size);

                    prev = this[indices[k] + 3 - 1].ToPoint(size);
                    if (prev.Y > curr.Y)
                    {
                        AET.Add(new ActiveEdge(curr, prev, CalculateColor(simulationParameters, this[indices[k]]), CalculateColor(simulationParameters, this[indices[k] + 3 - 1])));
                    }
                    else if (prev.Y < curr.Y)
                    {
                        AET.Remove(new ActiveEdge(prev, curr, Color.White, Color.White));
                    }
                    next = this[indices[k] + 1].ToPoint(size);
                    if (next.Y > curr.Y)
                    {
                        AET.Add(new ActiveEdge(curr, next, CalculateColor(simulationParameters, this[indices[k]]), CalculateColor(simulationParameters, this[indices[k] + 1])));
                    }
                    else if (next.Y < curr.Y)
                    {
                        AET.Remove(new ActiveEdge(next, curr, Color.White, Color.White));
                    }
                    k++;
                    curr = this[indices[k]].ToPoint(size);
                }
                AET.Sort();
                for (int i = 0; i < AET.Count; i += 2)
                {
                    brush.Color = InterpolateColorOnLine(AET[i].Cu, AET[i].Cv, AET[i].U, AET[i].V, new Point((int)AET[i].X, y));
                    g.FillRectangle(brush, (int)Math.Round(AET[i].X), y, 1, 1);
                    for (int j = (int)Math.Round(AET[i].X) + 1; j < (int)Math.Round(AET[i + 1].X); j++)
                    {
                        brush.Color = InterpolateColor(colorA, colorB, colorC, new Point(j,y), size);
                        g.FillRectangle(brush, j, y, 1, 1);
                    }
                    brush.Color = InterpolateColorOnLine(AET[i + 1].Cu, AET[i + 1].Cv, AET[i + 1].U, AET[i + 1].V, new Point((int)AET[i + 1].X, y));
                    g.FillRectangle(brush, (int)Math.Round(AET[i + 1].X), y, 1, 1);
                    AET[i].Step();
                    AET[i + 1].Step();
                }
                y++;
            }
            
            Color CalculateColor(SimulationParameters simulationParameters, Vertex v)
            {
                NormalVector L = (simulationParameters.Sun - v.Coordinates).GetVersor();
                NormalVector N = v.Normal.GetVersor();
                NormalVector R = 2 * N.Product(L) * N - L;

                double lL = (double)simulationParameters.LightColor.R / 255;
                double lO = (double)simulationParameters.ObjectColor.R / 255;
                double l = simulationParameters.Kd * lL * lO * N.Cosinus(L) + simulationParameters.Ks * lL * lO * Math.Pow(simulationParameters.V.Cosinus(R), simulationParameters.M);
                byte r = (byte)(l * 255);

                lL = (double)simulationParameters.LightColor.G / 255;
                lO = (double)simulationParameters.ObjectColor.G / 255;
                l = simulationParameters.Kd * lL * lO * N.Cosinus(L) + simulationParameters.Ks * lL * lO * Math.Pow(simulationParameters.V.Cosinus(R), simulationParameters.M);
                byte g = (byte)(l * 255);
            
            
                lL = (double)simulationParameters.LightColor.B / 255;
                lO = (double)simulationParameters.ObjectColor.B / 255;
                l = simulationParameters.Kd * lL * lO * N.Cosinus(L) + simulationParameters.Ks * lL * lO * Math.Pow(simulationParameters.V.Cosinus(R), simulationParameters.M);
                byte b = (byte)(l * 255);

                return Color.FromArgb(255, r, g, b);
            
            }

            Color InterpolateColor(Color cA, Color cB, Color cC, Point v, int size)
            {
                Point pA = a.ToPoint(size);
                Point pB = this.b.ToPoint(size);
                Point pC = c.ToPoint(size);
                double area = Area(pA, pB, pC);
                double areaA = Area(v, pB, pC);
                double areaB = Area(pA, v, pC);
                double areaC = Area(pA, pB, v);

                byte bA, bB, bC;

                bA = cA.R;
                bB = cB.R;
                bC = cC.R;
                //byte r = (byte)((bA * areaA / area + bB * areaB / area + bC * areaC / area) * 255);
                byte r = (byte)(((double)bA * areaA / area + (double)bB * areaB / area + (double)bC * areaC / area));

                bA = cA.G;
                bB = cB.G;
                bC = cC.G;
                //byte g = (byte)((bA * areaA / area + bB * areaB / area + bC * areaC / area) * 255);
                byte g = (byte)(((double)bA * areaA / area + (double)bB * areaB / area + (double)bC * areaC / area));

                bA = cA.B;
                bB = cB.B;
                bC = cC.B;
                //byte b = (byte)((bA * areaA / area + bB * areaB / area + bC * areaC / area) * 255);
                byte b = (byte)(((double)bA * areaA / area + (double)bB * areaB / area + (double)bC * areaC / area));

                return Color.FromArgb(255, r, g, b);

            }

            Color InterpolateColorOnLine(Color cA, Color cB, Point pA, Point pB, Point v)
            {
                byte bA, bB;
                double lA = Distance(pA, v);
                double lB = Distance(pB, v);
                double l = Distance(pA, pB);

                bA = cA.R;
                bB = cB.R;
                byte r = (byte)((double)bA * lB / l + (double)bB * lA / l);

                bA = cA.G;
                bB = cB.G;
                byte g = (byte)((double)bA * lB / l + (double)bB * lA / l);


                bA = cA.B;
                bB = cB.B;
                byte b = (byte)((double)bA * lB / l + (double)bB * lA / l);

                return Color.FromArgb(255, r, g, b);


            }

            double Area(Point a, Point b, Point c)
            {
                double lA = Distance(a, b);
                double lB = Distance(b, c);
                double lC = Distance(c, a);
                double p = (lA + lB + lC) / 2;

                return Math.Sqrt(p * (p - lA) * (p - lB) * (p - lC));
            }

            double Distance(Point a, Point b)
            {
                return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
            }
        }
    }

    public class ActiveEdge : IComparable<ActiveEdge>
    {
        double x;
        double m;

        Point u;
        Point v;

        Color cu;
        Color cv;

        public double X => x;

        public Color Cu { get => cu; }
        public Color Cv { get => cv; }

        public Point U { get => u; }

        public Point V { get => v; }

        public ActiveEdge(Point u, Point v, Color cu, Color cv)
        {
            this.u = u;
            this.v = v;

            x = u.X;
            if (u.Y != v.Y) m = (v.X - u.X) / (double)(v.Y - u.Y);
            else m = 0;

            this.cu = cu;
            this.cv = cv;
        }

        public int CompareTo(ActiveEdge? other)
        {
            return x.CompareTo(other.x);
        }

        public override bool Equals(object? obj)
        {
            return obj is ActiveEdge edge &&
                   u == edge.u &&
                   v == edge.v;
        }

        public void Step()
        {
            x += m;
        }
    }

}
