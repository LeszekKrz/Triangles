using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace Triangles
{
    internal class LockableBitmap
    {
        Bitmap source = null;
        IntPtr iPtr = IntPtr.Zero;
        BitmapData bitmapData = null;
    }
}
