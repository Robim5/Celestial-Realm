namespace projcelestialrealm
{
    partial class principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbanimes = new System.Windows.Forms.Label();
            this.lbsair = new System.Windows.Forms.Label();
            this.lbperfil = new System.Windows.Forms.Label();
            this.lblista = new System.Windows.Forms.Label();
            this.lbalterar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projcelestialrealm.Properties.Resources.imagemprincipalfundoptpt;
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(931, 602);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbanimes
            // 
            this.lbanimes.AutoSize = true;
            this.lbanimes.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbanimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbanimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbanimes.Location = new System.Drawing.Point(78, 252);
            this.lbanimes.Name = "lbanimes";
            this.lbanimes.Size = new System.Drawing.Size(145, 37);
            this.lbanimes.TabIndex = 1;
            this.lbanimes.Text = "ANIMES";
            this.lbanimes.Click += new System.EventHandler(this.lbanimes_Click);
            // 
            // lbsair
            // 
            this.lbsair.AutoSize = true;
            this.lbsair.BackColor = System.Drawing.Color.CadetBlue;
            this.lbsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsair.Location = new System.Drawing.Point(795, 549);
            this.lbsair.Name = "lbsair";
            this.lbsair.Size = new System.Drawing.Size(109, 32);
            this.lbsair.TabIndex = 6;
            this.lbsair.Text = "<-- sair";
            this.lbsair.Click += new System.EventHandler(this.lbsair_Click);
            // 
            // lbperfil
            // 
            this.lbperfil.AutoSize = true;
            this.lbperfil.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbperfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbperfil.Location = new System.Drawing.Point(78, 425);
            this.lbperfil.Name = "lbperfil";
            this.lbperfil.Size = new System.Drawing.Size(133, 37);
            this.lbperfil.TabIndex = 7;
            this.lbperfil.Text = "PERFIL";
            this.lbperfil.Click += new System.EventHandler(this.lbperfil_Click);
            // 
            // lblista
            // 
            this.lblista.AutoSize = true;
            this.lblista.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblista.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblista.Location = new System.Drawing.Point(134, 332);
            this.lblista.Name = "lblista";
            this.lblista.Size = new System.Drawing.Size(111, 37);
            this.lblista.TabIndex = 8;
            this.lblista.Text = "LISTA";
            this.lblista.Click += new System.EventHandler(this.lblista_Click);
            // 
            // lbalterar
            // 
            this.lbalterar.AutoSize = true;
            this.lbalterar.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbalterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbalterar.Location = new System.Drawing.Point(135, 507);
            this.lbalterar.Name = "lbalterar";
            this.lbalterar.Size = new System.Drawing.Size(88, 37);
            this.lbalterar.TabIndex = 9;
            this.lbalterar.Text = "ADD";
            this.lbalterar.Click += new System.EventHandler(this.lbalterar_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(930, 590);
            this.Controls.Add(this.lbalterar);
            this.Controls.Add(this.lblista);
            this.Controls.Add(this.lbperfil);
            this.Controls.Add(this.lbsair);
            this.Controls.Add(this.lbanimes);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.Load += new System.EventHandler(this.principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbanimes;
        private System.Windows.Forms.Label lbsair;
        private System.Windows.Forms.Label lbperfil;
        private System.Windows.Forms.Label lblista;
        private System.Windows.Forms.Label lbalterar;
    }
}