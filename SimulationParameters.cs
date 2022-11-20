using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    internal abstract class SimulationParameters
    {
        double kd;
        double ks;
         Color lightColor;
        VertexCoordinates sun;
        NormalVector v;
        int m;

        public double Kd { get => kd; }
        public double Ks { get => ks; }
        public Color LightColor { get => lightColor; }

        public int M { get => m; }
        public NormalVector V { get => v; }
        public VertexCoordinates Sun { get => sun; set => sun = value; }
        

        public SimulationParameters(double kd, double ks, Color lightColor, int m)
        {
            this.kd = kd;
            this.ks = ks;
            this.lightColor = lightColor;
            sun = new VertexCoordinates(0, 0, 0);
            v = new NormalVector(0, 0, 1);
            this.m = m;
        }

        public abstract Color GetColor(int i, int j);
    }

    internal class SimulationParametersWithColor : SimulationParameters
    {
        Color objectColor;

        public Color ObjectColor { get => objectColor; }
        public SimulationParametersWithColor(double kd, double ks, Color lightColor, int m, Color objectColor) : base(kd, ks, lightColor, m)
        {
            this.objectColor = objectColor;
        }

        public override Color GetColor(int i, int j)
        {
            return objectColor;
        }
    }

    internal class SimulationParametersWithTexture : SimulationParameters
    {
        LockableBitmap texture;

        public SimulationParametersWithTexture(double kd, double ks, Color lightColor, int m, LockableBitmap texture) : base(kd, ks, lightColor, m)
        {
            this.texture = texture;
        }

        public override Color GetColor(int i, int j)
        {
            return texture.GetPixel(i, j);
        }

        public NormalVector GetVector(int i, int j)
        {
            Color color = texture.GetPixel(i, j);
            double nx = (double)(color.R - 127) / 128;
            double ny = (double)(color.G - 127) / 128;
            double nz = (double)(color.B - 127) / 128;
            return new NormalVector(nx, ny, nz);
        }
    }

    internal class SimulationParametersWithBoth : SimulationParametersWithTexture
    {
        Color objectColor;

        public SimulationParametersWithBoth(double kd, double ks, Color lightColor, int m, LockableBitmap texture, Color objectColor) : base(kd, ks, lightColor, m, texture)
        {
            this.objectColor = objectColor;
        }

        public SimulationParametersWithBoth(SimulationParametersWithColor sp, LockableBitmap texture): base(sp.Kd, sp.Ks, sp.LightColor, sp.M, texture)
        {
            this.objectColor = sp.ObjectColor;
        }

        public override Color GetColor(int i, int j)
        {
            return objectColor;
        }
    }
}
