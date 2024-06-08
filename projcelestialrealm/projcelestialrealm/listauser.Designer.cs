namespace projcelestialrealm
{
    partial class listauser
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
            this.pcbfotoperf = new System.Windows.Forms.PictureBox();
            this.dgvvistos = new System.Windows.Forms.DataGridView();
            this.NomeAnimeVistos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroVistos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbnomeuser = new System.Windows.Forms.Label();
            this.lbfechar = new System.Windows.Forms.Label();
            this.dgvempausa = new System.Windows.Forms.DataGridView();
            this.NomeAnimeEmEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroEmEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcontaver = new System.Windows.Forms.DataGridView();
            this.NomeAnimeAVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroAVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvparaver = new System.Windows.Forms.DataGridView();
            this.NomeAnimeParaVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroParaVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdesistidos = new System.Windows.Forms.DataGridView();
            this.NomeAnimeDesistidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroDesistidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbfotoperf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvistos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontaver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvparaver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdesistidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projcelestialrealm.Properties.Resources.fundolistauser;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1125, 763);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcbfotoperf
            // 
            this.pcbfotoperf.Cursor = System.Windows.Forms.Cursors.No;
            this.pcbfotoperf.Location = new System.Drawing.Point(480, 79);
            this.pcbfotoperf.Name = "pcbfotoperf";
            this.pcbfotoperf.Size = new System.Drawing.Size(132, 133);
            this.pcbfotoperf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbfotoperf.TabIndex = 1;
            this.pcbfotoperf.TabStop = false;
            this.pcbfotoperf.Click += new System.EventHandler(this.pcbfotoperf_Click);
            // 
            // dgvvistos
            // 
            this.dgvvistos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvistos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeAnimeVistos,
            this.GeneroVistos});
            this.dgvvistos.Location = new System.Drawing.Point(12, 271);
            this.dgvvistos.Name = "dgvvistos";
            this.dgvvistos.ReadOnly = true;
            this.dgvvistos.RowHeadersWidth = 62;
            this.dgvvistos.RowTemplate.Height = 28;
            this.dgvvistos.Size = new System.Drawing.Size(543, 227);
            this.dgvvistos.TabIndex = 2;
            this.dgvvistos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvistos_CellContentClick);
            // 
            // NomeAnimeVistos
            // 
            this.NomeAnimeVistos.HeaderText = "Nome do Anime";
            this.NomeAnimeVistos.MinimumWidth = 8;
            this.NomeAnimeVistos.Name = "NomeAnimeVistos";
            this.NomeAnimeVistos.ReadOnly = true;
            this.NomeAnimeVistos.Width = 150;
            // 
            // GeneroVistos
            // 
            this.GeneroVistos.HeaderText = "Gênero";
            this.GeneroVistos.MinimumWidth = 8;
            this.GeneroVistos.Name = "GeneroVistos";
            this.GeneroVistos.ReadOnly = true;
            this.GeneroVistos.Width = 150;
            // 
            // lbnomeuser
            // 
            this.lbnomeuser.AutoSize = true;
            this.lbnomeuser.BackColor = System.Drawing.Color.LightCyan;
            this.lbnomeuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnomeuser.Location = new System.Drawing.Point(211, 79);
            this.lbnomeuser.Name = "lbnomeuser";
            this.lbnomeuser.Size = new System.Drawing.Size(86, 29);
            this.lbnomeuser.TabIndex = 7;
            this.lbnomeuser.Text = "NOME";
            // 
            // lbfechar
            // 
            this.lbfechar.AutoSize = true;
            this.lbfechar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbfechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfechar.Location = new System.Drawing.Point(201, 127);
            this.lbfechar.Name = "lbfechar";
            this.lbfechar.Size = new System.Drawing.Size(53, 15);
            this.lbfechar.TabIndex = 8;
            this.lbfechar.Text = "<--Voltar";
            this.lbfechar.Click += new System.EventHandler(this.lbfechar_Click);
            // 
            // dgvempausa
            // 
            this.dgvempausa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempausa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeAnimeEmEspera,
            this.GeneroEmEspera});
            this.dgvempausa.Location = new System.Drawing.Point(587, 271);
            this.dgvempausa.Name = "dgvempausa";
            this.dgvempausa.ReadOnly = true;
            this.dgvempausa.RowHeadersWidth = 62;
            this.dgvempausa.RowTemplate.Height = 28;
            this.dgvempausa.Size = new System.Drawing.Size(525, 227);
            this.dgvempausa.TabIndex = 9;
            this.dgvempausa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempausa_CellContentClick);
            // 
            // NomeAnimeEmEspera
            // 
            this.NomeAnimeEmEspera.HeaderText = "Nome do Anime";
            this.NomeAnimeEmEspera.MinimumWidth = 8;
            this.NomeAnimeEmEspera.Name = "NomeAnimeEmEspera";
            this.NomeAnimeEmEspera.ReadOnly = true;
            this.NomeAnimeEmEspera.Width = 150;
            // 
            // GeneroEmEspera
            // 
            this.GeneroEmEspera.HeaderText = "Gênero";
            this.GeneroEmEspera.MinimumWidth = 8;
            this.GeneroEmEspera.Name = "GeneroEmEspera";
            this.GeneroEmEspera.ReadOnly = true;
            this.GeneroEmEspera.Width = 150;
            // 
            // dgvcontaver
            // 
            this.dgvcontaver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcontaver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeAnimeAVer,
            this.GeneroAVer});
            this.dgvcontaver.Location = new System.Drawing.Point(675, 12);
            this.dgvcontaver.Name = "dgvcontaver";
            this.dgvcontaver.ReadOnly = true;
            this.dgvcontaver.RowHeadersWidth = 62;
            this.dgvcontaver.RowTemplate.Height = 28;
            this.dgvcontaver.Size = new System.Drawing.Size(437, 230);
            this.dgvcontaver.TabIndex = 10;
            this.dgvcontaver.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcontaver_CellContentClick);
            // 
            // NomeAnimeAVer
            // 
            this.NomeAnimeAVer.HeaderText = "Nome do Anime";
            this.NomeAnimeAVer.MinimumWidth = 8;
            this.NomeAnimeAVer.Name = "NomeAnimeAVer";
            this.NomeAnimeAVer.ReadOnly = true;
            this.NomeAnimeAVer.Width = 150;
            // 
            // GeneroAVer
            // 
            this.GeneroAVer.HeaderText = "Gênero";
            this.GeneroAVer.MinimumWidth = 8;
            this.GeneroAVer.Name = "GeneroAVer";
            this.GeneroAVer.ReadOnly = true;
            this.GeneroAVer.Width = 150;
            // 
            // dgvparaver
            // 
            this.dgvparaver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvparaver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeAnimeParaVer,
            this.GeneroParaVer});
            this.dgvparaver.Location = new System.Drawing.Point(12, 532);
            this.dgvparaver.Name = "dgvparaver";
            this.dgvparaver.ReadOnly = true;
            this.dgvparaver.RowHeadersWidth = 62;
            this.dgvparaver.RowTemplate.Height = 28;
            this.dgvparaver.Size = new System.Drawing.Size(531, 227);
            this.dgvparaver.TabIndex = 11;
            this.dgvparaver.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvparaver_CellContentClick);
            // 
            // NomeAnimeParaVer
            // 
            this.NomeAnimeParaVer.HeaderText = "Nome do Anime";
            this.NomeAnimeParaVer.MinimumWidth = 8;
            this.NomeAnimeParaVer.Name = "NomeAnimeParaVer";
            this.NomeAnimeParaVer.ReadOnly = true;
            this.NomeAnimeParaVer.Width = 150;
            // 
            // GeneroParaVer
            // 
            this.GeneroParaVer.HeaderText = "Gênero";
            this.GeneroParaVer.MinimumWidth = 8;
            this.GeneroParaVer.Name = "GeneroParaVer";
            this.GeneroParaVer.ReadOnly = true;
            this.GeneroParaVer.Width = 150;
            // 
            // dgvdesistidos
            // 
            this.dgvdesistidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdesistidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeAnimeDesistidos,
            this.GeneroDesistidos});
            this.dgvdesistidos.Location = new System.Drawing.Point(587, 532);
            this.dgvdesistidos.Name = "dgvdesistidos";
            this.dgvdesistidos.ReadOnly = true;
            this.dgvdesistidos.RowHeadersWidth = 62;
            this.dgvdesistidos.RowTemplate.Height = 28;
            this.dgvdesistidos.Size = new System.Drawing.Size(525, 227);
            this.dgvdesistidos.TabIndex = 12;
            this.dgvdesistidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdesistidos_CellContentClick);
            // 
            // NomeAnimeDesistidos
            // 
            this.NomeAnimeDesistidos.HeaderText = "Nome do Anime";
            this.NomeAnimeDesistidos.MinimumWidth = 8;
            this.NomeAnimeDesistidos.Name = "NomeAnimeDesistidos";
            this.NomeAnimeDesistidos.ReadOnly = true;
            this.NomeAnimeDesistidos.Width = 150;
            // 
            // GeneroDesistidos
            // 
            this.GeneroDesistidos.HeaderText = "Gênero";
            this.GeneroDesistidos.MinimumWidth = 8;
            this.GeneroDesistidos.Name = "GeneroDesistidos";
            this.GeneroDesistidos.ReadOnly = true;
            this.GeneroDesistidos.Width = 150;
            // 
            // listauser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1124, 760);
            this.Controls.Add(this.dgvdesistidos);
            this.Controls.Add(this.dgvparaver);
            this.Controls.Add(this.dgvcontaver);
            this.Controls.Add(this.dgvempausa);
            this.Controls.Add(this.lbfechar);
            this.Controls.Add(this.lbnomeuser);
            this.Controls.Add(this.dgvvistos);
            this.Controls.Add(this.pcbfotoperf);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listauser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listauser";
            this.Load += new System.EventHandler(this.listauser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbfotoperf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvistos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvparaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdesistidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbfotoperf;
        private System.Windows.Forms.Label lbnomeuser;
        private System.Windows.Forms.Label lbfechar;
        public System.Windows.Forms.DataGridView dgvempausa;
        public System.Windows.Forms.DataGridView dgvcontaver;
        public System.Windows.Forms.DataGridView dgvvistos;
        public System.Windows.Forms.DataGridView dgvparaver;
        public System.Windows.Forms.DataGridView dgvdesistidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAnimeVistos;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroVistos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAnimeEmEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroEmEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAnimeAVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroAVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAnimeParaVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroParaVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAnimeDesistidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroDesistidos;
    }
}