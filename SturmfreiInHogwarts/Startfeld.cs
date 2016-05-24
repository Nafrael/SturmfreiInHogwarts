using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SturmfreiInHogwarts
{
    public class Startfeld : Spielfeld
    {
        private int spieler;

        public Startfeld(int i)
        {
            if (i == 1)
            {
                setFeldBitmap(new Bitmap("Bitmaps\\startfeld_1.bmp"));
                spieler = 1;
            }
            if (i == 2)
            {
                setFeldBitmap(new Bitmap("Bitmaps\\startfeld_2.bmp"));
                spieler = 2;
            }
            setBesetzt(false);
        }

        public void setSpieler(int i)
        {
            spieler = i;
        }

        public int getSpieler()
        {
            return this.spieler;
        }
    }
}
