namespace projcelestialrealm
{
    partial class listaanime
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
            this.pcbimganime = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.cbselectpesq = new System.Windows.Forms.ComboBox();
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpesq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimganime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbimganime
            // 
            this.pcbimganime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbimganime.Image = global::projcelestialrealm.Properties.Resources.fundoimagem;
            this.pcbimganime.Location = new System.Drawing.Point(659, 120);
            this.pcbimganime.Name = "pcbimganime";
            this.pcbimganime.Size = new System.Drawing.Size(300, 378);
            this.pcbimganime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbimganime.TabIndex = 1;
            this.pcbimganime.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projcelestialrealm.Properties.Resources.fundolistaanime;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(991, 539);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.Location = new System.Drawing.Point(139, 72);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(272, 39);
            this.txtpesquisa.TabIndex = 2;
            // 
            // cbselectpesq
            // 
            this.cbselectpesq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbselectpesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbselectpesq.FormattingEnabled = true;
            this.cbselectpesq.Location = new System.Drawing.Point(352, 12);
            this.cbselectpesq.Name = "cbselectpesq";
            this.cbselectpesq.Size = new System.Drawing.Size(271, 40);
            this.cbselectpesq.TabIndex = 3;
            this.cbselectpesq.SelectedIndexChanged += new System.EventHandler(this.cbselectpesq_SelectedIndexChanged);
            // 
            // dgvlista
            // 
            this.dgvlista.AllowUserToDeleteRows = false;
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvlista.Location = new System.Drawing.Point(28, 129);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.RowHeadersWidth = 62;
            this.dgvlista.RowTemplate.Height = 28;
            this.dgvlista.Size = new System.Drawing.Size(595, 364);
            this.dgvlista.TabIndex = 4;
            this.dgvlista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlista_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orchid;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(900, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "<--- Voltar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnpesq
            // 
            this.btnpesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesq.Location = new System.Drawing.Point(409, 72);
            this.btnpesq.Name = "btnpesq";
            this.btnpesq.Size = new System.Drawing.Size(82, 38);
            this.btnpesq.TabIndex = 6;
            this.btnpesq.Text = "Ir";
            this.btnpesq.UseVisualStyleBackColor = true;
            this.btnpesq.Click += new System.EventHandler(this.btnpesq_Click);
            // 
            // listaanime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(991, 530);
            this.Controls.Add(this.btnpesq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvlista);
            this.Controls.Add(this.cbselectpesq);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.pcbimganime);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listaanime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listaanime";
            this.Load += new System.EventHandler(this.listaanime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbimganime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbimganime;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.ComboBox cbselectpesq;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvlista;
        private System.Windows.Forms.Button btnpesq;
    }
}