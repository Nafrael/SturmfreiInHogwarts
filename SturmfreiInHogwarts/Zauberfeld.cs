using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SturmfreiInHogwarts
{
    public class Zauberfeld : Spielfeld
    {
        private int art; //0 == spruch, 1 == trank
        private Zauber zauber;

        public Zauberfeld(int a)
        {
            if (a == 0)
            {
                setFeldBitmap(new Bitmap("Bitmaps\\zauberfeld.bmp"));
            }
            else if (a == 1)
            {
                setFeldBitmap(new Bitmap("Bitmaps\\trankfeld.bmp"));
            }
        }

        public void setArt(int a)
        {
            this.art = a;
        }

        public int getArt()
        {
            return this.art;
        }

        public Zauber getZauber()
        {
            return this.zauber;
        }

        public void setZauber(Zauber z)
        {
            this.zauber = z;
        }
    }
}
