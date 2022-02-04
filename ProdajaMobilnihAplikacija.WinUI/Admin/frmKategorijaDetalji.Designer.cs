namespace ProdajaMobilnihAplikacija.WinUI.Admin
{
    partial class frmKategorijaDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategorijaDetalji));
            this.btnExit = new System.Windows.Forms.Button();
            this.Kategorija = new System.Windows.Forms.Label();
            this.Oznaka = new System.Windows.Forms.Label();
            this.txtOznaka = new System.Windows.Forms.TextBox();
            this.Opis = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(387, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 108;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Kategorija
            // 
            this.Kategorija.AutoSize = true;
            this.Kategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kategorija.Location = new System.Drawing.Point(107, 21);
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Size = new System.Drawing.Size(173, 39);
            this.Kategorija.TabIndex = 113;
            this.Kategorija.Text = "Kategorija";
            // 
            // Oznaka
            // 
            this.Oznaka.AutoSize = true;
            this.Oznaka.Location = new System.Drawing.Point(16, 98);
            this.Oznaka.Name = "Oznaka";
            this.Oznaka.Size = new System.Drawing.Size(44, 13);
            this.Oznaka.TabIndex = 112;
            this.Oznaka.Text = "Oznaka";
            // 
            // txtOznaka
            // 
            this.txtOznaka.Location = new System.Drawing.Point(114, 91);
            this.txtOznaka.Name = "txtOznaka";
            this.txtOznaka.Size = new System.Drawing.Size(265, 20);
            this.txtOznaka.TabIndex = 104;
            // 
            // Opis
            // 
            this.Opis.AutoSize = true;
            this.Opis.Location = new System.Drawing.Point(16, 175);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(28, 13);
            this.Opis.TabIndex = 110;
            this.Opis.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(114, 172);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(265, 20);
            this.txtOpis.TabIndex = 106;
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(16, 137);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(34, 13);
            this.Naziv.TabIndex = 109;
            this.Naziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(114, 134);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(265, 20);
            this.txtNaziv.TabIndex = 105;
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(164, 217);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(138, 57);
            this.btnSnimi.TabIndex = 114;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // frmKategorijaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 298);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Kategorija);
            this.Controls.Add(this.Oznaka);
            this.Controls.Add(this.txtOznaka);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.txtNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKategorijaDetalji";
            this.Text = "frmKategorijaDetalji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Kategorija;
        private System.Windows.Forms.Label Oznaka;
        private System.Windows.Forms.TextBox txtOznaka;
        private System.Windows.Forms.Label Opis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnSnimi;
    }
}