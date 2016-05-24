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
        private bool spielername1Ok = false;
        private bool spielername2Ok = false;

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
            Point locationLblSpielername1 = new Point((startmenueHintergrund.Width / 2) - (lblSpielername1.Width / 2 + 10 + (tbSpielername1.Width / 2)), startmenueHintergrund.Height / 2 - 50);
            Point locationLblSpielername2 = new Point(locationLblSpielername1.X, locationLblSpielername1.Y + 50);

            lblSpielername1.Location = locationLblSpielername1;
            lblSpielername2.Location = locationLblSpielername2;

            Point locationTbSpielername1 = new Point(locationLblSpielername1.X + lblSpielername1.Width + 10, locationLblSpielername1.Y);
            Point locationTbSpielername2 = new Point(locationLblSpielername2.X + lblSpielername2.Width + 10, locationLblSpielername2.Y);

            tbSpielername1.Location = locationTbSpielername1;
            tbSpielername2.Location = locationTbSpielername2;

            // Starte-Spiel-Button
            btnStarteSpiel.Size = new System.Drawing.Size(lblSpielername1.Width + 10 + tbSpielername2.Width, 28);
            Point locationBtnStarteSpiel = new Point(locationLblSpielername1.X, locationTbSpielername2.Y + 50);

            btnStarteSpiel.Location = locationBtnStarteSpiel;

            Point locationLblFehlerSpielerName1 = new Point(locationTbSpielername1.X + tbSpielername2.Width + 10, locationTbSpielername1.Y);
            Point locationLblFehlerSpielerName2 = new Point(locationTbSpielername2.X + tbSpielername2.Width + 10, locationTbSpielername2.Y);

            lblFehlerSpielername1.Location = locationLblFehlerSpielerName1;
            lblFehlerSpielername2.Location = locationLblFehlerSpielerName2;

            // Titel
            Point locationLblTitel = new Point((startmenueHintergrund.Width / 2) - (lblTitel.Width / 2), lblSpielername1.Location.Y - 100);

            lblTitel.Location = locationLblTitel;

            tbSpielername1.Focus();
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

        private void btnStarteSpiel_Click(object sender, EventArgs e)
        {
            // Grafiken aus Menü verstecken
            lblSpielername1.Hide();
            lblSpielername2.Hide();
            tbSpielername1.Hide();
            tbSpielername2.Hide();
            lblTitel.Hide();
            btnStarteSpiel.Hide();

            zeigeSpielbrett();
        }

        private void tbSpielername1_Leave(object sender, EventArgs e)
        {
            if (spielernameIstNichtLeer(tbSpielername1.Text))
            {
                if (!spielernameIstNichtZuKurz(tbSpielername1.Text))
                {
                    spielername1Ok = false;
                    lblFehlerSpielername1.Text = "Zu kurz!";
                }
                else if (!spielernameIstNichtZuLang(tbSpielername1.Text))
                {
                    spielername1Ok = false;
                    lblFehlerSpielername1.Text = "Zu lang!";
                }
                else
                {
                    spielername1Ok = true;
                    lblFehlerSpielername1.Text = "";
                }
            }
            else
            {
                spielername1Ok = false;
                lblFehlerSpielername1.Text = "";
            }

            if (alleSpielerNamenOk())
            {
                btnStarteSpiel.Enabled = true;
            }
            else
            {
                btnStarteSpiel.Enabled = false;
            }
        }

        private void tbSpielername2_Leave(object sender, EventArgs e)
        {
            if (spielernameIstNichtLeer(tbSpielername2.Text))
            {
                if (!spielernameIstNichtZuKurz(tbSpielername2.Text))
                {
                    spielername2Ok = false;
                    lblFehlerSpielername2.Text = "Zu kurz!";
                }
                else if (!spielernameIstNichtZuLang(tbSpielername2.Text))
                {
                    spielername2Ok = false;
                    lblFehlerSpielername2.Text = "Zu lang!";
                }
                else
                {
                    spielername2Ok = true;
                    lblFehlerSpielername2.Text = "";
                }
            }
            else
            {
                spielername2Ok = false;
                lblFehlerSpielername2.Text = "";
            }

            if (alleSpielerNamenOk())
            {
                btnStarteSpiel.Enabled = true;
            }
            else
            {
                btnStarteSpiel.Enabled = false;
            }
        }

        private bool spielernameIstNichtLeer(String spielername)
        {
            return spielername != "";
        }

        private bool spielernameIstNichtZuKurz(String spielername)
        {
            return spielername.Length >= 3;
        }

        private bool spielernameIstNichtZuLang(String spielername)
        {
            return spielername.Length <= 15;
        }

        private bool alleSpielerNamenOk()
        {
            return (spielername1Ok && spielername2Ok);
        }
    }
}
