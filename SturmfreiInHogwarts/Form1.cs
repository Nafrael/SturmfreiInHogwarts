using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SturmfreiInHogwarts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            zeigeStartmenue();
        }

        public void zeigeStartmenue()
        {
            Startmenue startmenue = new Startmenue();

            // hintergrund
            Bitmap startmenueHintergrund = startmenue.getHintergrund();
            pictureBox1.ClientSize = startmenueHintergrund.Size;
            pictureBox1.Image = startmenueHintergrund;
            this.Width = startmenueHintergrund.Width + 40;
            this.Height = startmenueHintergrund.Height + 70;

            // spielernamen
            Point locationLblSpielername1 = new Point((startmenueHintergrund.Width / 2) - lblSpielername1.Width - 10, startmenueHintergrund.Height / 2 - 50);
            Point locationLblSpielername2 = new Point(locationLblSpielername1.X, locationLblSpielername1.Y + 50);

            lblSpielername1.Location = locationLblSpielername1;
            lblSpielername2.Location = locationLblSpielername2;

            Point locationTbSpielername1 = new Point(locationLblSpielername1.X + lblSpielername2.Width + 10, locationLblSpielername1.Y);
            Point locationTbSpielername2 = new Point(locationLblSpielername2.X + lblSpielername2.Width + 10, locationLblSpielername2.Y);

            tbSpielername2.Location = locationTbSpielername1;
            tbSpielername1.Location = locationTbSpielername2;
            
            Point localBtnStarteSpiel = new Point(locationLblSpielername1.X, locationTbSpielername2.Y + 50);

            btnStarteSpiel.Location = localBtnStarteSpiel;
            
            tbSpielername2.Focus();
        }

        public void zeigeSpielbrett()
        {
            Spielbrett spielbrett = new Spielbrett();
            pictureBox1.ClientSize = spielbrett.getBackgroundBitmap().Size;
            spielbrett.zeichneSpielbrett();
            Bitmap spielbrettBitmap = spielbrett.getBackgroundBitmap();
            pictureBox1.Image = spielbrettBitmap;
            this.Width = spielbrettBitmap.Width + 40;
            this.Height = spielbrettBitmap.Height + 70;
        }

        private void tbSpielername2_TextChanged(object sender, EventArgs e)
        {
            if (tbSpielername2.Text != "" && tbSpielername1.Text != "")
            {
               if ((tbSpielername2.TextLength >= 3) && (tbSpielername1.TextLength >= 3))
               {
                    btnStarteSpiel.Enabled = true;
               }
            }
        }

        private void btnStarteSpiel_Click(object sender, EventArgs e)
        {
            // Grafiken aus Menü verstecken
            lblSpielername2.Hide();
            lblSpielername1.Hide();
            tbSpielername2.Hide();
            tbSpielername1.Hide();
            btnStarteSpiel.Hide();

            zeigeSpielbrett();
        }
   }
}
