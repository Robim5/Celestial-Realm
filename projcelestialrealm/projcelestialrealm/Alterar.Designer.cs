namespace projcelestialrealm
{
    partial class Alterar
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
            this.dgvadicionar = new System.Windows.Forms.DataGridView();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.txtsinopse = new System.Windows.Forms.TextBox();
            this.txtep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.lbvoltar = new System.Windows.Forms.Label();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btnfav = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadicionar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projcelestialrealm.Properties.Resources.fundoatualizarapagar;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1055, 622);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvadicionar
            // 
            this.dgvadicionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvadicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvadicionar.Location = new System.Drawing.Point(23, 105);
            this.dgvadicionar.Name = "dgvadicionar";
            this.dgvadicionar.ReadOnly = true;
            this.dgvadicionar.RowHeadersWidth = 62;
            this.dgvadicionar.RowTemplate.Height = 28;
            this.dgvadicionar.Size = new System.Drawing.Size(310, 481);
            this.dgvadicionar.TabIndex = 4;
            this.dgvadicionar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvadicionar_CellClick);
            this.dgvadicionar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvadicionar_CellContentClick);
            this.dgvadicionar.SelectionChanged += new System.EventHandler(this.dgvadicionar_SelectionChanged);
            // 
            // txtgenero
            // 
            this.txtgenero.Cursor = System.Windows.Forms.Cursors.No;
            this.txtgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgenero.Location = new System.Drawing.Point(617, 150);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.ReadOnly = true;
            this.txtgenero.Size = new System.Drawing.Size(311, 39);
            this.txtgenero.TabIndex = 6;
            // 
            // txtsinopse
            // 
            this.txtsinopse.Cursor = System.Windows.Forms.Cursors.No;
            this.txtsinopse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsinopse.Location = new System.Drawing.Point(409, 195);
            this.txtsinopse.Multiline = true;
            this.txtsinopse.Name = "txtsinopse";
            this.txtsinopse.ReadOnly = true;
            this.txtsinopse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtsinopse.Size = new System.Drawing.Size(519, 112);
            this.txtsinopse.TabIndex = 7;
            // 
            // txtep
            // 
            this.txtep.Cursor = System.Windows.Forms.Cursors.No;
            this.txtep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtep.Location = new System.Drawing.Point(671, 313);
            this.txtep.Name = "txtep";
            this.txtep.ReadOnly = true;
            this.txtep.Size = new System.Drawing.Size(199, 30);
            this.txtep.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Episódios";
            // 
            // btnadicionar
            // 
            this.btnadicionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnadicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionar.Location = new System.Drawing.Point(409, 424);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(269, 60);
            this.btnadicionar.TabIndex = 10;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = false;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // lbvoltar
            // 
            this.lbvoltar.AutoSize = true;
            this.lbvoltar.BackColor = System.Drawing.Color.MediumBlue;
            this.lbvoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvoltar.Location = new System.Drawing.Point(676, 520);
            this.lbvoltar.Name = "lbvoltar";
            this.lbvoltar.Size = new System.Drawing.Size(69, 26);
            this.lbvoltar.TabIndex = 12;
            this.lbvoltar.Text = "Voltar";
            this.lbvoltar.Click += new System.EventHandler(this.lbvoltar_Click);
            // 
            // cbcategoria
            // 
            this.cbcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Items.AddRange(new object[] {
            "Vistos",
            "A ver",
            "Para ver",
            "Desistidos",
            "Em pausa"});
            this.cbcategoria.Location = new System.Drawing.Point(462, 361);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(408, 40);
            this.cbcategoria.TabIndex = 13;
            this.cbcategoria.SelectedIndexChanged += new System.EventHandler(this.cbcategoria_SelectedIndexChanged);
            // 
            // txtnome
            // 
            this.txtnome.Cursor = System.Windows.Forms.Cursors.No;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(409, 105);
            this.txtnome.Name = "txtnome";
            this.txtnome.ReadOnly = true;
            this.txtnome.Size = new System.Drawing.Size(349, 39);
            this.txtnome.TabIndex = 14;
            // 
            // btnfav
            // 
            this.btnfav.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnfav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfav.Location = new System.Drawing.Point(716, 424);
            this.btnfav.Name = "btnfav";
            this.btnfav.Size = new System.Drawing.Size(226, 60);
            this.btnfav.TabIndex = 16;
            this.btnfav.Text = "Favoritar";
            this.btnfav.UseVisualStyleBackColor = false;
            this.btnfav.Click += new System.EventHandler(this.btnfav_Click);
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1049, 613);
            this.Controls.Add(this.btnfav);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.lbvoltar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtep);
            this.Controls.Add(this.txtsinopse);
            this.Controls.Add(this.txtgenero);
            this.Controls.Add(this.dgvadicionar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar";
            this.Load += new System.EventHandler(this.Alterar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadicionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.TextBox txtsinopse;
        private System.Windows.Forms.TextBox txtep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label lbvoltar;
        public System.Windows.Forms.DataGridView dgvadicionar;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnfav;
    }
}