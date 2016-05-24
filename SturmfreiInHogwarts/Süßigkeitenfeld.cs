using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SturmfreiInHogwarts
{
    public class Süßigkeitenfeld : Spielfeld
    {
        private int punkte;
        private int art; //0 == bohnen, 1 == frosch

        public Süßigkeitenfeld(int a)
        {
            if (a == 0)
            {
                setFeldBitmap(new Bitmap("Bitmaps\\bohnenfeld.bmp"));
                punkte = 50;
            }
            else if (a == 1)
            {
                setFeldBitmap(new Bitmap("Bitmaps\\froschfeld.bmp"));
                punkte = 25;
            }
        }

        public int getPunkte()
        {
            return this.punkte;
        }

        public int getArt()
        {
            return this.art;
        }

        public void setArt(int i)
        {
            if (i == 0 || i == 1)
            {
                this.art = i;
            }
        }
    }
}
