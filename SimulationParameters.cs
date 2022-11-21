using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    // drzewo dziedziczenia klas przekazujacych parametry symulacji, kolor obiektu, teksture i/lub mape wektorow noemalnych
    // wszystkie klasy posiadaja metode GetColor(), a klasy z mapa wektorow rowniez GetVector(), przez co trojkat w wiekszosci przypadkow nie musi wiedziec ktora z sytuacji zachodzi
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

        public LockableBitmap Texture { get => texture; }

        public SimulationParametersWithTexture(double kd, double ks, Color lightColor, int m, LockableBitmap texture) : base(kd, ks, lightColor, m)
        {
            this.texture = texture;
        }

        public override Color GetColor(int i, int j)
        {
            return texture.GetPixel(i, j);
        }
    }

    internal abstract class SimulationParametersWithNormal : SimulationParameters
    {
        LockableBitmap normalMap;

        public SimulationParametersWithNormal(double kd, double ks, Color lightColor, int m, LockableBitmap normalMap) : base(kd, ks, lightColor, m)
        {
            this.normalMap = normalMap;
        }

        public abstract override Color GetColor(int i, int j);


        public NormalVector GetVector(int i, int j)
        {
            Color color = normalMap.GetPixel(i, j);
            double nx = (double)(color.R - 127) / 128;
            double ny = (double)(color.G - 127) / 128;
            double nz = (double)(color.B - 127) / 128;
            return new NormalVector(nx, ny, nz);
        }
    }

    internal class SimulationParametersWithColorAndNormal : SimulationParametersWithNormal
    {
        Color objectColor;

        public SimulationParametersWithColorAndNormal(double kd, double ks, Color lightColor, int m, LockableBitmap normalMap, Color objectColor) : base(kd, ks, lightColor, m, normalMap)
        {
            this.objectColor = objectColor;
        }

        public SimulationParametersWithColorAndNormal(SimulationParametersWithColor sp, LockableBitmap normalMap): base(sp.Kd, sp.Ks, sp.LightColor, sp.M, normalMap)
        {
            this.objectColor = sp.ObjectColor;
        }

        public override Color GetColor(int i, int j)
        {
            return objectColor;
        }
    }

    internal class SimulationParametersWithTextureAndNormal : SimulationParametersWithNormal
    {
        LockableBitmap texture;

        public SimulationParametersWithTextureAndNormal(double kd, double ks, Color lightColor, int m, LockableBitmap normalMap, LockableBitmap texture) : base(kd, ks, lightColor, m, normalMap)
        {
            this.texture = texture;
        }

        public SimulationParametersWithTextureAndNormal(SimulationParametersWithTexture sp, LockableBitmap normalMap) : base(sp.Kd, sp.Ks, sp.LightColor, sp.M, normalMap)
        {
            this.texture = sp.Texture;
        }

        public override Color GetColor(int i, int j)
        {
            return texture.GetPixel(i, j);
        }
    }
}
