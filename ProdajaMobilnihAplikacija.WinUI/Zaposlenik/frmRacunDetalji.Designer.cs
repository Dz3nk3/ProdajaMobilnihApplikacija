namespace ProdajaMobilnihAplikacija.WinUI.Zaposlenik
{
    partial class frmRacunDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRacunDetalji));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatumPlacanja = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.RacunNasliov = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.UkupnaKolicina = new System.Windows.Forms.Label();
            this.txtNacinPlacanja = new System.Windows.Forms.TextBox();
            this.UkupnaCijena = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 127;
            this.label1.Text = "DatumPlacanja";
            // 
            // txtDatumPlacanja
            // 
            this.txtDatumPlacanja.Location = new System.Drawing.Point(137, 97);
            this.txtDatumPlacanja.Name = "txtDatumPlacanja";
            this.txtDatumPlacanja.Size = new System.Drawing.Size(265, 20);
            this.txtDatumPlacanja.TabIndex = 126;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(355, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 121;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RacunNasliov
            // 
            this.RacunNasliov.AutoSize = true;
            this.RacunNasliov.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RacunNasliov.Location = new System.Drawing.Point(69, 19);
            this.RacunNasliov.Name = "RacunNasliov";
            this.RacunNasliov.Size = new System.Drawing.Size(242, 39);
            this.RacunNasliov.TabIndex = 125;
            this.RacunNasliov.Text = "Detalji Racuna";
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(39, 137);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(36, 13);
            this.Datum.TabIndex = 124;
            this.Datum.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(137, 134);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(265, 20);
            this.txtCijena.TabIndex = 118;
            // 
            // UkupnaKolicina
            // 
            this.UkupnaKolicina.AutoSize = true;
            this.UkupnaKolicina.Location = new System.Drawing.Point(39, 214);
            this.UkupnaKolicina.Name = "UkupnaKolicina";
            this.UkupnaKolicina.Size = new System.Drawing.Size(76, 13);
            this.UkupnaKolicina.TabIndex = 123;
            this.UkupnaKolicina.Text = "NacinPlacanja";
            // 
            // txtNacinPlacanja
            // 
            this.txtNacinPlacanja.Location = new System.Drawing.Point(137, 211);
            this.txtNacinPlacanja.Name = "txtNacinPlacanja";
            this.txtNacinPlacanja.Size = new System.Drawing.Size(265, 20);
            this.txtNacinPlacanja.TabIndex = 120;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.AutoSize = true;
            this.UkupnaCijena.Location = new System.Drawing.Point(39, 176);
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.Size = new System.Drawing.Size(44, 13);
            this.UkupnaCijena.TabIndex = 122;
            this.UkupnaCijena.Text = "Kolicina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(137, 173);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(265, 20);
            this.txtKolicina.TabIndex = 119;
            // 
            // frmRacunDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatumPlacanja);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.RacunNasliov);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.UkupnaKolicina);
            this.Controls.Add(this.txtNacinPlacanja);
            this.Controls.Add(this.UkupnaCijena);
            this.Controls.Add(this.txtKolicina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRacunDetalji";
            this.Text = "frmRacunDetalji";
            this.Load += new System.EventHandler(this.frmRacunDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatumPlacanja;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label RacunNasliov;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label UkupnaKolicina;
        private System.Windows.Forms.TextBox txtNacinPlacanja;
        private System.Windows.Forms.Label UkupnaCijena;
        private System.Windows.Forms.TextBox txtKolicina;
    }
}