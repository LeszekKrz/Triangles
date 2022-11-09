using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    internal class Vertex
    {
        int x;
        int y;
        int z;

        int nx;
        int ny;
        int nz;

        public Vertex(int x, int y, int z, int nx, int ny, int nz)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.nx = nx;
            this.ny = ny;
            this.nz = nz;
        }
    }
}
