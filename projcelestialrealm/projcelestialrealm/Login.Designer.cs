namespace projcelestialrealm
{
    partial class Login
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cbdia = new System.Windows.Forms.ComboBox();
            this.cbano = new System.Windows.Forms.ComboBox();
            this.cbmes = new System.Windows.Forms.ComboBox();
            this.rbnmasc = new System.Windows.Forms.RadioButton();
            this.rbnfem = new System.Windows.Forms.RadioButton();
            this.btniniciarsessao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(45, 198);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(381, 44);
            this.txtnome.TabIndex = 1;
            this.txtnome.Text = "nome";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(45, 288);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(381, 44);
            this.txtemail.TabIndex = 2;
            this.txtemail.Text = "email";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(45, 369);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(381, 44);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.Text = "password";
            // 
            // cbdia
            // 
            this.cbdia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdia.FormattingEnabled = true;
            this.cbdia.Location = new System.Drawing.Point(45, 518);
            this.cbdia.Name = "cbdia";
            this.cbdia.Size = new System.Drawing.Size(104, 37);
            this.cbdia.TabIndex = 4;
            this.cbdia.Click += new System.EventHandler(this.cbdia_Click);
            // 
            // cbano
            // 
            this.cbano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbano.FormattingEnabled = true;
            this.cbano.Location = new System.Drawing.Point(324, 518);
            this.cbano.Name = "cbano";
            this.cbano.Size = new System.Drawing.Size(102, 37);
            this.cbano.TabIndex = 5;
            this.cbano.SelectedIndexChanged += new System.EventHandler(this.cbano_SelectedIndexChanged);
            this.cbano.Click += new System.EventHandler(this.cbano_Click);
            // 
            // cbmes
            // 
            this.cbmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmes.FormattingEnabled = true;
            this.cbmes.Location = new System.Drawing.Point(167, 518);
            this.cbmes.Name = "cbmes";
            this.cbmes.Size = new System.Drawing.Size(139, 37);
            this.cbmes.TabIndex = 6;
            this.cbmes.SelectedIndexChanged += new System.EventHandler(this.cbmes_SelectedIndexChanged);
            this.cbmes.Click += new System.EventHandler(this.cbmes_Click);
            // 
            // rbnmasc
            // 
            this.rbnmasc.AutoSize = true;
            this.rbnmasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnmasc.Location = new System.Drawing.Point(61, 454);
            this.rbnmasc.Name = "rbnmasc";
            this.rbnmasc.Size = new System.Drawing.Size(147, 33);
            this.rbnmasc.TabIndex = 7;
            this.rbnmasc.TabStop = true;
            this.rbnmasc.Text = "Masculino";
            this.rbnmasc.UseVisualStyleBackColor = true;
            // 
            // rbnfem
            // 
            this.rbnfem.AutoSize = true;
            this.rbnfem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnfem.Location = new System.Drawing.Point(264, 454);
            this.rbnfem.Name = "rbnfem";
            this.rbnfem.Size = new System.Drawing.Size(139, 33);
            this.rbnfem.TabIndex = 9;
            this.rbnfem.TabStop = true;
            this.rbnfem.Text = "Feminino";
            this.rbnfem.UseVisualStyleBackColor = true;
            // 
            // btniniciarsessao
            // 
            this.btniniciarsessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciarsessao.Location = new System.Drawing.Point(324, 580);
            this.btniniciarsessao.Name = "btniniciarsessao";
            this.btniniciarsessao.Size = new System.Drawing.Size(114, 92);
            this.btniniciarsessao.TabIndex = 10;
            this.btniniciarsessao.Text = "Iniciar\r\nSessão\r\n";
            this.btniniciarsessao.UseVisualStyleBackColor = true;
            this.btniniciarsessao.Click += new System.EventHandler(this.btniniciarsessao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "<- voltar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projcelestialrealm.Properties.Resources.fundoiniciarsessao;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 817);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(466, 815);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btniniciarsessao);
            this.Controls.Add(this.rbnfem);
            this.Controls.Add(this.rbnmasc);
            this.Controls.Add(this.cbmes);
            this.Controls.Add(this.cbano);
            this.Controls.Add(this.cbdia);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox cbdia;
        private System.Windows.Forms.ComboBox cbano;
        private System.Windows.Forms.ComboBox cbmes;
        private System.Windows.Forms.RadioButton rbnmasc;
        private System.Windows.Forms.RadioButton rbnfem;
        private System.Windows.Forms.Button btniniciarsessao;
        private System.Windows.Forms.Label label1;
    }
}