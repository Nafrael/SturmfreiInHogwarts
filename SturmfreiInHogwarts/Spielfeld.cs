using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SturmfreiInHogwarts
{
    public class Spielfeld
    {
        private bool besetzt;
        private Bitmap feldBitmap;

        public Spielfeld() {
            besetzt = false;
            feldBitmap = new Bitmap("Bitmaps\\feld.bmp");
            feldBitmap.MakeTransparent(Color.Black);
        }

        public void setBesetzt(bool value) {
            this.besetzt = value;
        }

        public bool isBesetzt() {
            return this.besetzt;
        }

        public void setFeldBitmap(Bitmap bitmap) {
            this.feldBitmap = bitmap;
            this.feldBitmap.MakeTransparent(Color.Black);
        }

        public Bitmap getFeldBitmap() {
            return this.feldBitmap;
        }

    }
}
