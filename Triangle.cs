﻿using System;
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

        Color[] colors;
        Point[] points;

        Color color;
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

            colors = new Color[0];
            points = new Point[0];
        }


        public Vertex this[int i]
        {
            get {
                switch (i%3)
                {
                    case 0: return a;
                    case 1: return b;
                    case 2: return c;
                    default: return new Vertex(new VertexCoordinates(0,0,0), new NormalVector(0,0,0));
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

        public void PaintTriangle(int size, LockableBitmap bitmap, SimulationParameters simulationParameters, bool interpolateColors)
        {
            List<Vertex> vertices = new List<Vertex>() { a, b, c };
            vertices.Sort();
            int[] indices = vertices.Select(v => this[v]).ToArray();

            List<ActiveEdge> AET;
            int y = this[indices[0]].ToPoint(size).Y;

            colors = new Color[3] { CalculateColor(simulationParameters, this[0]), CalculateColor(simulationParameters, this[1]), CalculateColor(simulationParameters, this[2]) };
            points = new Point[3] { a.ToPoint(size), b.ToPoint(size), c.ToPoint(size) };
            AET = new List<ActiveEdge>();
            int k = 0;
            Point curr = this[indices[0]].ToPoint(size);

            while (y != this[indices[2]].ToPoint(size).Y)
            {
                StepAET(y, indices, size, ref curr, ref k, AET);
                if (interpolateColors) PaintAETwithInterpolatedColor(AET, y, size, bitmap);
                else PaintAETwithInterpolatedVectors(AET, y, size, bitmap, simulationParameters);
                y++;
            }
        }

        void StepAET(int y, int[] indices, int size,ref Point curr, ref int k, List<ActiveEdge> AET)
        {
            Point prev, next;
            while (y == curr.Y)
            {
                prev = this[indices[k] + 3 - 1].ToPoint(size);
                if (prev.Y > curr.Y)
                {
                    AET.Add(new ActiveEdge(indices[k], indices[k] - 1, curr.X, Angle(curr, prev)));
                }
                else if (prev.Y < curr.Y)
                {
                    AET.Remove(new ActiveEdge(indices[k] - 1, indices[k]));
                }
                next = this[indices[k] + 1].ToPoint(size);
                if (next.Y > curr.Y)
                {
                    AET.Add(new ActiveEdge(indices[k], indices[k] + 1, curr.X, Angle(curr, next)));
                }
                else if (next.Y < curr.Y)
                {
                    AET.Remove(new ActiveEdge(indices[k] + 1, indices[k]));
                }
                k++;
                curr = this[indices[k]].ToPoint(size);
            }
            AET.Sort();
        }

        void PaintAETwithInterpolatedColor(List<ActiveEdge> AET, int y, int size, LockableBitmap bitmap)
        {
            for (int i = 0; i < AET.Count; i += 2)
            {
                color = InterpolateColorOnLine(AET[i], new Point((int)AET[i].X, y));
                //g.FillRectangle(brush, (int)Math.Round(AET[i].X), y, 1, 1);
                bitmap.SetPixel((int)Math.Round(AET[i].X), y, color);
                for (int j = (int)Math.Round(AET[i].X) + 1; j < (int)Math.Round(AET[i + 1].X); j++)
                {
                    color = InterpolateColor(colors[0], colors[1], colors[2], new Point(j, y), size);
                    bitmap.SetPixel(j, y, color);
                }
                color = InterpolateColorOnLine(AET[i + 1], new Point((int)AET[i + 1].X, y));
                bitmap.SetPixel((int)Math.Round(AET[i + 1].X), y, color);
                AET[i].Step();
                AET[i + 1].Step();
            }
        }

        void PaintAETwithInterpolatedVectors(List<ActiveEdge> AET, int y, int size, LockableBitmap bitmap, SimulationParameters simulationParameters)
        {
            for (int i = 0; i < AET.Count; i += 2)
            {
                Vertex interpolated = InterpolateVertexOnEdge(new Point((int)AET[i].X, y), AET[i]);
                color = CalculateColor(simulationParameters, interpolated);
                bitmap.SetPixel((int)Math.Round(AET[i].X), y, color);
                for (int j = (int)Math.Round(AET[i].X) + 1; j < (int)Math.Round(AET[i + 1].X); j++)
                {
                    interpolated = InterpolateVertexInTriangle(new Point(j, y));
                    color = CalculateColor(simulationParameters, interpolated);
                    bitmap.SetPixel(j, y, color);
                }
                interpolated = InterpolateVertexOnEdge(new Point((int)AET[i + 1].X, y), AET[i+1]);
                color = CalculateColor(simulationParameters, interpolated);
                bitmap.SetPixel((int)Math.Round(AET[i + 1].X), y, color);
                AET[i].Step();
                AET[i + 1].Step();
            }
        }

        Vertex InterpolateVertexOnEdge(Point v, ActiveEdge edge)
        {
            Vertex beginning = this[edge.I];
            Vertex end = this[edge.J];
            EdgeRatios ratios = new EdgeRatios(points[edge.I], points[edge.J], v);
            double x = ratios.Interpolate(beginning.Coordinates.X, end.Coordinates.X);
            double y = ratios.Interpolate(beginning.Coordinates.Y, end.Coordinates.Y);
            double z = ratios.Interpolate(beginning.Coordinates.Z, end.Coordinates.Z);
            VertexCoordinates coordinates = new VertexCoordinates(x, y, z);
            double nx = ratios.Interpolate(beginning.Normal.Xn, end.Normal.Xn);
            double ny = ratios.Interpolate(beginning.Normal.Yn, end.Normal.Yn);
            double nz = ratios.Interpolate(beginning.Normal.Zn, end.Normal.Zn);
            NormalVector vector = new NormalVector(nx, ny, nz);
            return new Vertex(coordinates, vector);
        }

        Vertex InterpolateVertexInTriangle(Point v)
        {
            TriangleRatios ratios = new TriangleRatios(points[0], points[1], points[2], v);
            double x = ratios.Interpolate(a.Coordinates.X, b.Coordinates.X, c.Coordinates.X);
            double y = ratios.Interpolate(a.Coordinates.Y, b.Coordinates.Y, c.Coordinates.Y);
            double z = ratios.Interpolate(a.Coordinates.Z, b.Coordinates.Z, c.Coordinates.Z);
            VertexCoordinates coordinates = new VertexCoordinates(x, y, z);
            double nx = ratios.Interpolate(a.Normal.Xn, b.Normal.Xn, c.Normal.Xn);
            double ny = ratios.Interpolate(a.Normal.Yn, b.Normal.Yn, c.Normal.Yn);
            double nz = ratios.Interpolate(a.Normal.Zn, b.Normal.Zn, c.Normal.Zn);
            NormalVector vector = new NormalVector(nx, ny, nz);
            return new Vertex(coordinates, vector);
            
        }

        Color CalculateColor(SimulationParameters simulationParameters, Vertex v)
        {
            NormalVector L = (simulationParameters.Sun - v.Coordinates).GetVersor();
            NormalVector N = v.Normal.GetVersor();
            NormalVector R = (2 * N.Product(L) * N - L);

            double lL, lO;
            lL = (double)simulationParameters.LightColor.R / 255;
            lO = (double)simulationParameters.ObjectColor.R / 255;
            double l = simulationParameters.Kd * lL * lO * N.Cosinus(L) + simulationParameters.Ks * lL * lO * Math.Pow(simulationParameters.V.Cosinus(R), simulationParameters.M);
            
            if (l > 1) l = 1;
            byte r = (byte)(l * 255);

            lL = (double)simulationParameters.LightColor.G / 255;
            lO = (double)simulationParameters.ObjectColor.G / 255;
            l = simulationParameters.Kd * lL * lO * N.Cosinus(L) + simulationParameters.Ks * lL * lO * Math.Pow(simulationParameters.V.Cosinus(R), simulationParameters.M);

            if (l > 1) l = 1;
            byte g = (byte)(l * 255);


            lL = (double)simulationParameters.LightColor.B / 255;
            lO = (double)simulationParameters.ObjectColor.B / 255;
            l = simulationParameters.Kd * lL * lO * N.Cosinus(L) + simulationParameters.Ks * lL * lO * Math.Pow(simulationParameters.V.Cosinus(R), simulationParameters.M);

            if (l > 1) l = 1;
            byte b = (byte)(l * 255);

            return Color.FromArgb(255, r, g, b);

        }

        Color InterpolateColor(Color cA, Color cB, Color cC, Point v, int size)
        {
            TriangleRatios ratios = new TriangleRatios(this.a.ToPoint(size), this.b.ToPoint(size), this.c.ToPoint(size), v);

            byte r = (byte)ratios.Interpolate(cA.R, cB.R, cC.R);
            byte g = (byte)ratios.Interpolate(cA.G, cB.G, cC.G);
            byte b = (byte)ratios.Interpolate(cA.B, cB.B, cC.B);

            return Color.FromArgb(255, r, g, b);

        }

        Color InterpolateColorOnLine(ActiveEdge edge, Point v)
        {

            Color cA = colors[edge.I];
            Color cB = colors[edge.J];

            EdgeRatios ratios = new EdgeRatios(points[edge.I], points[edge.J], v);
            double dr = ratios.Interpolate(cA.R, cB.R);
            if (dr > 255) dr = 255;
            byte r = (byte)dr;
            double dg = ratios.Interpolate(cA.G, cB.G);
            if (dg > 255) dg = 255;
            byte g = (byte)dg;
            double db = ratios.Interpolate(cA.B, cB.B);
            if (db > 255) db = 255;
            byte b = (byte)db;

            return Color.FromArgb(255, r, g, b);


        }
        static public double Area(Point a, Point b, Point c)
        {
            double lA = Distance(a, b);
            double lB = Distance(b, c);
            double lC = Distance(c, a);
            double p = (lA + lB + lC) / 2;

            return Math.Sqrt(p * (p - lA) * (p - lB) * (p - lC));
        }

        public static double Distance(Point a, Point b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        static double Angle(Point u, Point v)
        {
            if (u.Y != v.Y) return (v.X - u.X) / (double)(v.Y - u.Y);
            else return 0;

        }
    }

    public class ActiveEdge : IComparable<ActiveEdge>
    {
        double x;
        double m;

        int i;
        int j;

        public double X => x;

        public int I => i;
        public int J => j;

        public ActiveEdge(int i, int j, int x, double m)
        {
            this.i = i >= 0 ? i % 3 : (i + 3) % 3;
            this.j = j >= 0 ? j % 3 : (j + 3) % 3;

            this.x = x;
            this.m = m;
        }

        public ActiveEdge(int i, int j): this(i,j,0,0)
        {
        }

        public int CompareTo(ActiveEdge? other)
        {
            if (other != null) return x.CompareTo(other.x);
            else return 1;
        }

        public override bool Equals(object? obj)
        {
            return obj is ActiveEdge edge &&
                   i == edge.i && j == edge.j;
        }

        public void Step()
        {
            x += m;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class TriangleRatios
    {
        double ratioA;
        double ratioB;
        double ratioC;

        public TriangleRatios(Point a, Point b, Point c, Point x)
        {
            double area = Triangle.Area(a, b, c);
            ratioA = Triangle.Area(x, b, c) / area;
            ratioB = Triangle.Area(a, x, c) / area;
            ratioC = Triangle.Area(a, b, x) / area;
        }

        public double Interpolate(double parA, double parB, double parC)
        {
            return parA * ratioA + parB * ratioB + parC * ratioC;
        }
    }

    public class EdgeRatios
    {
        double ratioA;
        double ratioB;
        public EdgeRatios(Point a, Point b, Point x)
        {
            double length = Triangle.Distance(a, b);
            ratioA = Triangle.Distance(x, b) / length;
            ratioB = Triangle.Distance(a, x) / length;
        }

        public double Interpolate(double parA, double parB)
        {
            return parA * ratioA + parB * ratioB;
        }
    }

}
