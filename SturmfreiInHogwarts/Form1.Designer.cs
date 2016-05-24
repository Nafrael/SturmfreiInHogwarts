namespace SturmfreiInHogwarts
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSpielername2 = new System.Windows.Forms.Label();
            this.tbSpielername1 = new System.Windows.Forms.TextBox();
            this.lblSpielername1 = new System.Windows.Forms.Label();
            this.tbSpielername2 = new System.Windows.Forms.TextBox();
            this.btnStarteSpiel = new System.Windows.Forms.Button();
            this.lblFehlerSpielername1 = new System.Windows.Forms.Label();
            this.lblFehlerSpielername2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 39);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblSpielername2
            // 
            this.lblSpielername2.AutoSize = true;
            this.lblSpielername2.BackColor = System.Drawing.Color.Transparent;
            this.lblSpielername2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpielername2.Location = new System.Drawing.Point(96, 286);
            this.lblSpielername2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpielername2.Name = "lblSpielername2";
            this.lblSpielername2.Size = new System.Drawing.Size(153, 22);
            this.lblSpielername2.TabIndex = 1;
            this.lblSpielername2.Text = "Name Spieler 2:";
            // 
            // tbSpielername1
            // 
            this.tbSpielername1.Location = new System.Drawing.Point(229, 209);
            this.tbSpielername1.Margin = new System.Windows.Forms.Padding(4);
            this.tbSpielername1.Name = "tbSpielername1";
            this.tbSpielername1.Size = new System.Drawing.Size(132, 22);
            this.tbSpielername1.TabIndex = 2;
            this.tbSpielername1.Leave += new System.EventHandler(this.tbSpielername1_Leave);
            // 
            // lblSpielername1
            // 
            this.lblSpielername1.AutoSize = true;
            this.lblSpielername1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpielername1.Location = new System.Drawing.Point(76, 210);
            this.lblSpielername1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpielername1.Name = "lblSpielername1";
            this.lblSpielername1.Size = new System.Drawing.Size(153, 22);
            this.lblSpielername1.TabIndex = 3;
            this.lblSpielername1.Text = "Name Spieler 1:";
            // 
            // tbSpielername2
            // 
            this.tbSpielername2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpielername2.Location = new System.Drawing.Point(236, 274);
            this.tbSpielername2.Margin = new System.Windows.Forms.Padding(4);
            this.tbSpielername2.Name = "tbSpielername2";
            this.tbSpielername2.Size = new System.Drawing.Size(132, 22);
            this.tbSpielername2.TabIndex = 4;
            this.tbSpielername2.Leave += new System.EventHandler(this.tbSpielername2_Leave);
            // 
            // btnStarteSpiel
            // 
            this.btnStarteSpiel.Enabled = false;
            this.btnStarteSpiel.Location = new System.Drawing.Point(236, 347);
            this.btnStarteSpiel.Margin = new System.Windows.Forms.Padding(4);
            this.btnStarteSpiel.Name = "btnStarteSpiel";
            this.btnStarteSpiel.Size = new System.Drawing.Size(256, 28);
            this.btnStarteSpiel.TabIndex = 5;
            this.btnStarteSpiel.Text = "Spiel starten";
            this.btnStarteSpiel.UseVisualStyleBackColor = true;
            this.btnStarteSpiel.Click += new System.EventHandler(this.btnStarteSpiel_Click);
            // 
            // lblFehlerSpielername1
            // 
            this.lblFehlerSpielername1.AutoSize = true;
            this.lblFehlerSpielername1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFehlerSpielername1.ForeColor = System.Drawing.Color.Red;
            this.lblFehlerSpielername1.Location = new System.Drawing.Point(368, 214);
            this.lblFehlerSpielername1.Name = "lblFehlerSpielername1";
            this.lblFehlerSpielername1.Size = new System.Drawing.Size(0, 22);
            this.lblFehlerSpielername1.TabIndex = 6;
            // 
            // lblFehlerSpielername2
            // 
            this.lblFehlerSpielername2.AutoSize = true;
            this.lblFehlerSpielername2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFehlerSpielername2.ForeColor = System.Drawing.Color.Red;
            this.lblFehlerSpielername2.Location = new System.Drawing.Point(368, 286);
            this.lblFehlerSpielername2.Name = "lblFehlerSpielername2";
            this.lblFehlerSpielername2.Size = new System.Drawing.Size(0, 22);
            this.lblFehlerSpielername2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 446);
            this.Controls.Add(this.lblFehlerSpielername2);
            this.Controls.Add(this.lblFehlerSpielername1);
            this.Controls.Add(this.btnStarteSpiel);
            this.Controls.Add(this.tbSpielername2);
            this.Controls.Add(this.lblSpielername1);
            this.Controls.Add(this.tbSpielername1);
            this.Controls.Add(this.lblSpielername2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSpielername2;
        private System.Windows.Forms.TextBox tbSpielername1;
        private System.Windows.Forms.Label lblSpielername1;
        private System.Windows.Forms.TextBox tbSpielername2;
        private System.Windows.Forms.Button btnStarteSpiel;
        private System.Windows.Forms.Label lblFehlerSpielername1;
        private System.Windows.Forms.Label lblFehlerSpielername2;
    }
}

