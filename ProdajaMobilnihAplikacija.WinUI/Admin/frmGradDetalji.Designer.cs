namespace ProdajaMobilnihAplikacija.WinUI.Admin
{
    partial class frmGradDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGradDetalji));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.Analiza = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.COjena = new System.Windows.Forms.Label();
            this.txtKlijent = new System.Windows.Forms.TextBox();
            this.UkupnaCijena = new System.Windows.Forms.Label();
            this.txtSoftver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textKreator = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 130;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(120, 272);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(265, 20);
            this.txtNaziv.TabIndex = 129;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(358, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 124;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // Analiza
            // 
            this.Analiza.AutoSize = true;
            this.Analiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Analiza.Location = new System.Drawing.Point(65, 9);
            this.Analiza.Name = "Analiza";
            this.Analiza.Size = new System.Drawing.Size(234, 39);
            this.Analiza.TabIndex = 128;
            this.Analiza.Text = "Softver Detalji";
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(22, 312);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(36, 13);
            this.Datum.TabIndex = 127;
            this.Datum.Text = "Cijena";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(120, 309);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(265, 20);
            this.txtDatum.TabIndex = 121;
            // 
            // COjena
            // 
            this.COjena.AutoSize = true;
            this.COjena.Location = new System.Drawing.Point(22, 389);
            this.COjena.Name = "COjena";
            this.COjena.Size = new System.Drawing.Size(54, 13);
            this.COjena.TabIndex = 126;
            this.COjena.Text = "Kategorija";
            // 
            // txtKlijent
            // 
            this.txtKlijent.Location = new System.Drawing.Point(120, 386);
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.Size = new System.Drawing.Size(265, 20);
            this.txtKlijent.TabIndex = 123;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.AutoSize = true;
            this.UkupnaCijena.Location = new System.Drawing.Point(22, 351);
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.Size = new System.Drawing.Size(38, 13);
            this.UkupnaCijena.TabIndex = 125;
            this.UkupnaCijena.Text = "Verzija";
            // 
            // txtSoftver
            // 
            this.txtSoftver.Location = new System.Drawing.Point(120, 348);
            this.txtSoftver.Name = "txtSoftver";
            this.txtSoftver.Size = new System.Drawing.Size(265, 20);
            this.txtSoftver.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 135;
            this.label2.Text = "Kreator aplikacije";
            // 
            // textKreator
            // 
            this.textKreator.Location = new System.Drawing.Point(120, 237);
            this.textKreator.Name = "textKreator";
            this.textKreator.Size = new System.Drawing.Size(265, 20);
            this.textKreator.TabIndex = 134;
            // 
            // frmGradDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textKreator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Analiza);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.COjena);
            this.Controls.Add(this.txtKlijent);
            this.Controls.Add(this.UkupnaCijena);
            this.Controls.Add(this.txtSoftver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGradDetalji";
            this.Text = "frmGradDetalji";
            this.Load += new System.EventHandler(this.frmGradDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Analiza;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label COjena;
        private System.Windows.Forms.TextBox txtKlijent;
        private System.Windows.Forms.Label UkupnaCijena;
        private System.Windows.Forms.TextBox txtSoftver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textKreator;
    }
}