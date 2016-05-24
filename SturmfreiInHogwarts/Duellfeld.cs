using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SturmfreiInHogwarts
{
    public class Duellfeld : Spielfeld
    {
        public Duellfeld()
        {
            setFeldBitmap(new Bitmap("Bitmaps\\duellfeld.bmp"));
        }
    }
}
