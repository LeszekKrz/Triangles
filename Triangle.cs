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

        public void PaintTriangle(int size, Graphics g)
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
                        AET.Add(new ActiveEdge(curr, prev));
                    }
                    else if (prev.Y < curr.Y)
                    {
                        AET.Remove(new ActiveEdge(prev, curr));
                    }
                    next = this[indices[k] +1 ].ToPoint(size);
                    if (next.Y > curr.Y)
                    {
                        AET.Add(new ActiveEdge(curr, next));
                    }
                    else if (next.Y < curr.Y)
                    {
                        AET.Remove(new ActiveEdge(next, curr));
                    }
                    k++;
                    curr = this[indices[k]].ToPoint(size);
                }
                //Debug.WriteLine("koniec petli AET");
                AET.Sort();
            //if (this[indices[0]].Coordinates.Y == this[indices[1]].Coordinates.Y)
            //{
            //    Debug.WriteLine("Pozioma");
            //}
                for (int i = 0; i < AET.Count; i += 2)
                {
                    //Debug.WriteLine($"{(int)Math.Round(AET[i].X)} {(int)Math.Round(AET[i + 1].X)}");
                    for (int j = (int)Math.Round(AET[i].X); j < (int)Math.Round(AET[i + 1].X); j++)
                    {
                        //Debug.WriteLine($"{(int)Math.Round(AET[i].X)} {j} {(int)Math.Round(AET[i + 1].X)}");
                        brush = new SolidBrush(Color.Green);
                        g.FillRectangle(brush, j, y, 1, 1);
                    }
                    AET[i].Step();
                    AET[i + 1].Step();
                }
                y++;
                //Debug.WriteLine("linia");
            }
            
        }
    }

    public class ActiveEdge : IComparable<ActiveEdge>
    {
        double x;
        double m;

        Point u;
        Point v;

        public double X => x;

        public ActiveEdge(Point u, Point v)
        {
            this.u = u;
            this.v = v;

            x = u.X;
            if (u.Y != v.Y) m = (v.X - u.X) / (double)(v.Y - u.Y);
            else m = 0;

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
