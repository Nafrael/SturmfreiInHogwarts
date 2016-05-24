using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SturmfreiInHogwarts
{
    class Startmenue
    {
        private Bitmap hintergrund;

        public Startmenue()
        {
            initialisiereHintergrund();
        }

        public void zeichneStartmenue()
        {
            
        }

        private void initialisiereHintergrund()
        {
            hintergrund = new Bitmap("Bitmaps\\hintergrund.bmp");
        }

        public Bitmap getHintergrund()
        {
            return hintergrund;
        }
    }
}
