namespace projcelestialrealm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.labellogin = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbfechar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projcelestialrealm.Properties.Resources.fundoperfeitodetodosusaragr;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 895);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtemail
            // 
            this.txtemail.AccessibleDescription = "Email";
            this.txtemail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtemail.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(38, 352);
            this.txtemail.Name = "txtemail";
            this.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtemail.Size = new System.Drawing.Size(427, 50);
            this.txtemail.TabIndex = 1;
            this.txtemail.Text = "Email";
            // 
            // txtpassword
            // 
            this.txtpassword.AccessibleDescription = "password";
            this.txtpassword.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtpassword.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(38, 460);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtpassword.Size = new System.Drawing.Size(427, 50);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.Text = "Passoword";
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labellogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labellogin.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.Location = new System.Drawing.Point(79, 605);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(355, 23);
            this.labellogin.TabIndex = 3;
            this.labellogin.Text = "Não tem uma conta criada? Clique aqui!!\r\n";
            this.labellogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labellogin.Click += new System.EventHandler(this.labellogin_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnlogin.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(54, 536);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(388, 50);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Entrar";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbfechar
            // 
            this.lbfechar.AutoSize = true;
            this.lbfechar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbfechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfechar.Location = new System.Drawing.Point(393, 855);
            this.lbfechar.Name = "lbfechar";
            this.lbfechar.Size = new System.Drawing.Size(85, 25);
            this.lbfechar.TabIndex = 5;
            this.lbfechar.Text = "X fechar";
            this.lbfechar.Click += new System.EventHandler(this.lbfechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(492, 889);
            this.Controls.Add(this.lbfechar);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lbfechar;
    }
}

