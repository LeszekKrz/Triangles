using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    internal class SimulationParameters
    {
        double kd;
        double ks;
        Color lightColor;
        Color objectColor;
        VertexCoordinates sun;
        NormalVector v;
        int m;

        public double Kd { get => kd; }
        public double Ks { get => ks; }
        public Color LightColor { get => lightColor; }
        public Color ObjectColor { get => objectColor; }

        public int M { get => m; }
        public NormalVector V { get => v; }
        public VertexCoordinates Sun { get => sun; set => sun = value; }
        

        public SimulationParameters(double kd, double ks, Color lightColor, Color objectColor, int m)
        {
            this.kd = kd;
            this.ks = ks;
            this.lightColor = lightColor;
            this.objectColor = objectColor;
            sun = new VertexCoordinates(0, 0, 0);
            v = new NormalVector(0, 0, 1);
            this.m = m;
        }

    }
}
