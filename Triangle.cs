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

        public void PaintTriangle(int size, Graphics g, PictureBox drawArea)
        {
            List<Vertex> vertices = new List<Vertex>() { a, b, c };
            vertices.Sort();
            int[] indices = vertices.Select(v => this[v]).ToArray() ;

            List<ActiveEdge> AET = new List<ActiveEdge>();
            int y = this[indices[0]].ToPoint(size).Y;

            int k = 0;

            Vertex curr;
            Vertex prev;
            Vertex next;

            curr = this[indices[k]];

            while (y != this[indices[2]].ToPoint(size).Y)
            {
                while (y == curr.Coordinates.Y)
                {
                    prev = this[this[this[indices[k] + 3 - 1]]];
                    if (prev.Coordinates.Y >= curr.Coordinates.Y)
                    {
                        AET.Add(new ActiveEdge(curr.ToPoint(size), prev.ToPoint(size)));
                    }
                    else
                    {
                        AET.Remove(new ActiveEdge(prev.ToPoint(size), curr.ToPoint(size)));
                    }
                    next = this[this[this[indices[k] + 1]]];
                    if (next.Coordinates.Y >= curr.Coordinates.Y)
                    {
                        AET.Add(new ActiveEdge(curr.ToPoint(size), next.ToPoint(size)));
                    }
                    else
                    {
                        AET.Remove(new ActiveEdge(prev.ToPoint(size), curr.ToPoint(size)));
                    }

                    k++;
                    curr = this[indices[k]];

                }
                AET.Sort();
                for (int i = 0; i < AET.Count; i *= 2)
                {
                    for (int j = (int)Math.Round(AET[i].X); j < (int)Math.Round(AET[i + 1].X); j++)
                    {
                        brush = new SolidBrush(Color.Green);
                        g.FillRectangle(brush, j, i, 1, 1);
                    }
                    AET[i].Step();
                    AET[i + 1].Step();
                }
                y++;
                drawArea.Refresh();
                Debug.WriteLine("linia");
            }
            
        }
    }

    public class ActiveEdge : IComparable<ActiveEdge>
    {
        double x;
        int yMax;
        double m;

        Point u;
        Point v;

        public double X => x;

        public ActiveEdge(Point u, Point v)
        {
            this.u = u;
            this.v = v;

            x = u.X;
            yMax = v.Y;
            if (u.Y != v.Y) m = (v.X - u.X) / (v.Y - u.Y);
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
