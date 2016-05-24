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
            this.tbSpielername2 = new System.Windows.Forms.TextBox();
            this.lblSpielername1 = new System.Windows.Forms.Label();
            this.tbSpielername1 = new System.Windows.Forms.TextBox();
            this.btnStarteSpiel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblSpielername2
            // 
            this.lblSpielername2.AutoSize = true;
            this.lblSpielername2.Location = new System.Drawing.Point(49, 232);
            this.lblSpielername2.Name = "lblSpielername2";
            this.lblSpielername2.Size = new System.Drawing.Size(82, 13);
            this.lblSpielername2.TabIndex = 1;
            this.lblSpielername2.Text = "Name Spieler 2:";
            // 
            // tbSpielername2
            // 
            this.tbSpielername2.Location = new System.Drawing.Point(160, 232);
            this.tbSpielername2.Name = "tbSpielername2";
            this.tbSpielername2.Size = new System.Drawing.Size(100, 20);
            this.tbSpielername2.TabIndex = 2;
            // 
            // lblSpielername1
            // 
            this.lblSpielername1.AutoSize = true;
            this.lblSpielername1.Location = new System.Drawing.Point(49, 179);
            this.lblSpielername1.Name = "lblSpielername1";
            this.lblSpielername1.Size = new System.Drawing.Size(82, 13);
            this.lblSpielername1.TabIndex = 3;
            this.lblSpielername1.Text = "Name Spieler 1:";
            // 
            // tbSpielername1
            // 
            this.tbSpielername1.Location = new System.Drawing.Point(160, 171);
            this.tbSpielername1.Name = "tbSpielername1";
            this.tbSpielername1.Size = new System.Drawing.Size(100, 20);
            this.tbSpielername1.TabIndex = 4;
            this.tbSpielername1.TextChanged += new System.EventHandler(this.tbSpielername2_TextChanged);
            // 
            // btnStarteSpiel
            // 
            this.btnStarteSpiel.Enabled = false;
            this.btnStarteSpiel.Location = new System.Drawing.Point(177, 282);
            this.btnStarteSpiel.Name = "btnStarteSpiel";
            this.btnStarteSpiel.Size = new System.Drawing.Size(192, 23);
            this.btnStarteSpiel.TabIndex = 5;
            this.btnStarteSpiel.Text = "Spiel starten";
            this.btnStarteSpiel.UseVisualStyleBackColor = true;
            this.btnStarteSpiel.Click += new System.EventHandler(this.btnStarteSpiel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 362);
            this.Controls.Add(this.btnStarteSpiel);
            this.Controls.Add(this.tbSpielername1);
            this.Controls.Add(this.lblSpielername1);
            this.Controls.Add(this.tbSpielername2);
            this.Controls.Add(this.lblSpielername2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSpielername2;
        private System.Windows.Forms.TextBox tbSpielername2;
        private System.Windows.Forms.Label lblSpielername1;
        private System.Windows.Forms.TextBox tbSpielername1;
        private System.Windows.Forms.Button btnStarteSpiel;
    }
}

