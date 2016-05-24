using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SturmfreiInHogwarts
{
    public class Zauber
    {
        private string name;
        private int art; // 0 == spruch, 1 == trank
        //Sprüche verleihen +x, Zauber können auch -x verleihen
        private int staerke;

        public Zauber()
        {
            name = "undefiniert";
            art = 0;
            staerke = 0;
        }

        public Zauber(string n, int a, int s)
        {
            this.name = n;
            this.art = a;
            this.staerke = s;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string n)
        {
            this.name = n;
        }

        public int getStaerke()
        {
            return this.staerke;
        }

        public void setStaerke(int s)
        {
            this.staerke = s;
        }

        public int getArt()
        {
            return this.art;
        }

        public void setArt(int a)
        {
            this.art = a;
        }

    }
}
