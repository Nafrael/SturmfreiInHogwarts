using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SturmfreiInHogwarts
{
    public class Highscore
    {
        private String scoreSp1 = "0", scoreSp2 = "0";
        private bool Süßigkeitenfeld, Duellereigniss;               //aus anderer Klasse
        private int turn;                                    //aus anderer Klasse (1 = Spieler1 / 2 = Spieler2)

        public Highscore(String s1 = "0", String s2="0")
        {
            int sSp1 = Convert.ToInt16(scoreSp1), sSp2 = Convert.ToInt16(scoreSp2);

            if (Süßigkeitenfeld == true)                     //Punktgewinn durch Sammelobjekte
            {
                if (turn == 1)
                {
                    sSp1 = sSp1 + Süßigkeitenfeld.punkte;               //feld.score ist Platzhalter für Wert des Feldes
                }
                if (turn == 2)
                {
                    sSp2= sSp2 + feld.score;
                }
            }

            if (Duellereigniss == true)                     //Veränderung des Scores bei Duellen
            {
                if (Sieg.Sp1 == true)
                {
                    sSp1 = sSp1 + 500;                      //Wert kann geändert werden
                    sSp2 = sSp2 - 500;
                }
                if (Sieg.Sp2 == true)
                {
                    sSp1 = sSp1 - 500;
                    sSp2 = sSp2 + 500;
                }
            }

            if (NeuFig.Spieler1 == true)                //Berechnung bei neuer Figur ins Spiel
            {
                sSp1 = sSp1 - (5000*NeuFig.Zahl);
            }
            if (Neufig.Spieler2 == true)
            {
                sSp2 = sSp2 - (5000*NeuFig.Zahl);
            }

            s1 = Convert.ToString(sSp1);
            s2 = Convert.ToString(sSp2);

            this.scoreSp1 = s1;
            this.scoreSp2 = s2;

        }    
    }
}
