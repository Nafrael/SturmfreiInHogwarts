using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace SturmfreiInHogwarts
{
    public class Spielbrett
    {
        private Bitmap hintergrund;
        private int[,] spielbrett;

        public Spielbrett() 
        {
            hintergrund = new Bitmap("Bitmaps\\hintergrund.bmp");
            spielbrett = new int[20, 16];
        }

        public Bitmap getBackgroundBitmap()
        {
            return hintergrund;
        }

        public void zeichneSpielbrett()
        {
            Graphics g = Graphics.FromImage(hintergrund);
            IndexToCoordinateConverter.Length = 50;
            this.setArrayToZero();

            try 
			{
                StreamReader streamReader = new StreamReader("spielfeld.txt");

                for (int y = 0; y < 16; y++)
                {
                    string content = streamReader.ReadLine();
					for (int x = 0; x < 20; x++) {
						char akt = content[x];
						int number = akt - '0';
						spielbrett[x,y] = number;
						Coordinates drawCoords = IndexToCoordinateConverter.Convert(x,y);
						switch (akt) {
							case '0':
								break;
							case '1':
								//Noch zusätzliche Nummer hinzufügen, zwischen Startfeld 1 und 2 muss unterschieden werden
								Startfeld startfeld1 = new Startfeld(1);
                                Bitmap startfeld1Bitmap = startfeld1.getFeldBitmap();
                                g.DrawImage(startfeld1Bitmap, drawCoords.X, drawCoords.Y, startfeld1Bitmap.Width, startfeld1Bitmap.Height);
								break;
							case '2':
                                Spielfeld spielfeld = new Spielfeld();
                                Bitmap spielfeldBitmap = spielfeld.getFeldBitmap();
								g.DrawImage(spielfeldBitmap, drawCoords.X, drawCoords.Y, spielfeldBitmap.Width, spielfeldBitmap.Height);
								break;
							case '3':
                                Süßigkeitenfeld schokofroschfeld = new Süßigkeitenfeld(1);
                                Bitmap schokofroschBitmap = schokofroschfeld.getFeldBitmap();
								g.DrawImage(schokofroschBitmap, drawCoords.X, drawCoords.Y, schokofroschBitmap.Width, schokofroschBitmap.Height);
								break;
							case '4':
                                Zauberfeld zaubertrankfeld = new Zauberfeld(1);
                                Bitmap zaubertrankBitmap = zaubertrankfeld.getFeldBitmap();
								g.DrawImage(zaubertrankBitmap, drawCoords.X, drawCoords.Y, zaubertrankBitmap.Width, zaubertrankBitmap.Height);
								break;
							case '5':
                                Duellfeld duellfeld = new Duellfeld();
                                Bitmap duellfeldBitmap = duellfeld.getFeldBitmap();
								g.DrawImage(duellfeldBitmap, drawCoords.X, drawCoords.Y, duellfeldBitmap.Width, duellfeldBitmap.Height);
								break;
							case '6':
                                Zauberfeld zauberspruchfeld = new Zauberfeld(0);
                                Bitmap zauberspruchBitmap = zauberspruchfeld.getFeldBitmap();
								g.DrawImage(zauberspruchBitmap, drawCoords.X, drawCoords.Y, zauberspruchBitmap.Width, zauberspruchBitmap.Height);
								break;
							case '7':
                                Süßigkeitenfeld bohnenfeld = new Süßigkeitenfeld(0);
                                Bitmap bohnenBitmap = bohnenfeld.getFeldBitmap();
								g.DrawImage(bohnenBitmap, drawCoords.X, drawCoords.Y, bohnenBitmap.Width, bohnenBitmap.Height);
								break;
                            case '8':
                                Startfeld startfeld2 = new Startfeld(2);
                                Bitmap startfeld2Bitmap = startfeld2.getFeldBitmap();
                                g.DrawImage(startfeld2Bitmap, drawCoords.X, drawCoords.Y, startfeld2Bitmap.Width, startfeld2Bitmap.Height);
                                break;
							default:
								Console.Write("Ungültiger Wert!");
								break;
						}
					}
					Console.WriteLine();
				}
			} catch (IOException e) {
				Console.WriteLine(e.Message);
			}
            g.Dispose();
        }

        private void setArrayToZero()
        {
            for (int xIndex = 0; xIndex < 20; xIndex += 1)
            {
                for (int yIndex = 0; yIndex < 16; yIndex += 1)
                {
                    spielbrett[xIndex, yIndex] = 0;
                }
            }
        }
    }
}
