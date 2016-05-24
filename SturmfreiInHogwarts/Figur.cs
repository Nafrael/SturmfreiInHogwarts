using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SturmfreiInHogwarts
{
    public class Figur
    {
        private int number;
        private int punkte;
        private List<Zauber> zauber;
        private Bitmap vorne;
        private Bitmap hinten;
        private Bitmap links;
        private Bitmap rechts;

        public Figur(int i, Bitmap v, Bitmap h, Bitmap r, Bitmap l)
        {
            this.number = i;
            punkte = 0;
            vorne = v;
            hinten = h;
            links = l;
            rechts = r;
            zauber = new List<Zauber>();
        }

        public void addZauber(Zauber z)
        {
            this.zauber.Add(z);
        }

        public void addPunkte(int i)
        {
            this.punkte += i;
        }

        public void removePunkte(int i)
        {
            this.punkte -= i;
        }

        public int getPunkte()
        {
            return this.punkte;
        }

        public int getNumber()
        {
            return this.number;
        }

        public List<Zauber> getZauber()
        {
            return this.zauber;
        }

        public Bitmap getVorne()
        {
            return this.vorne;
        }

        public Bitmap getHinten()
        {
            return this.hinten;
        }

        public Bitmap getRechts()
        {
            return this.rechts;
        }

        public Bitmap getLinks()
        {
            return this.links;
        }
    }
}
