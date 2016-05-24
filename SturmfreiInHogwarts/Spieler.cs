using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SturmfreiInHogwarts
{
    public class Spieler
    {
        private int number;
        private string name;
        private List<Figur> figuren;

        public Spieler(int i, string n)
        {
            this.number = i;
            this.name = n;
        }

        public void addFigur(Figur figur)
        {
            this.figuren.Add(figur);
        }

        public List<Figur> getFiguren()
        {
            return this.figuren;
        }

        public Figur getFigur(int i)
        {
            return this.figuren[i];
        }

        public int getNumber()
        {
            return this.number;
        }

        public string getName()
        {
            return this.name;
        }

        public void setNumber(int i)
        {
            this.number = i;
        }

        public void setName(string n)
        {
            this.name = n;
        }
    }
}
