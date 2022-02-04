namespace ProdajaMobilnihAplikacija.WinUI.Admin
{
    partial class frmOcjenaDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOcjenaDetalji));
            this.lableNazivAplikacije = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.labelKategorija = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.DojamLabel = new System.Windows.Forms.Label();
            this.Ocjenalabel = new System.Windows.Forms.Label();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.labelVerzija = new System.Windows.Forms.Label();
            this.txtMarkaa = new System.Windows.Forms.TextBox();
            this.Komentarlabel = new System.Windows.Forms.Label();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lableNazivAplikacije
            // 
            this.lableNazivAplikacije.AutoSize = true;
            this.lableNazivAplikacije.Location = new System.Drawing.Point(25, 275);
            this.lableNazivAplikacije.Name = "lableNazivAplikacije";
            this.lableNazivAplikacije.Size = new System.Drawing.Size(81, 13);
            this.lableNazivAplikacije.TabIndex = 142;
            this.lableNazivAplikacije.Text = "Naziv aplikacije";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(131, 272);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(265, 20);
            this.txtCijena.TabIndex = 135;
            // 
            // labelKategorija
            // 
            this.labelKategorija.AutoSize = true;
            this.labelKategorija.Location = new System.Drawing.Point(33, 238);
            this.labelKategorija.Name = "labelKategorija";
            this.labelKategorija.Size = new System.Drawing.Size(54, 13);
            this.labelKategorija.TabIndex = 141;
            this.labelKategorija.Text = "Kategorija";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(131, 235);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(265, 20);
            this.txtModel.TabIndex = 134;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(367, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 136;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DojamLabel
            // 
            this.DojamLabel.AutoSize = true;
            this.DojamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DojamLabel.Location = new System.Drawing.Point(21, 9);
            this.DojamLabel.Name = "DojamLabel";
            this.DojamLabel.Size = new System.Drawing.Size(307, 39);
            this.DojamLabel.TabIndex = 140;
            this.DojamLabel.Text = "Ocjene i komentari";
            // 
            // Ocjenalabel
            // 
            this.Ocjenalabel.AutoSize = true;
            this.Ocjenalabel.Location = new System.Drawing.Point(33, 124);
            this.Ocjenalabel.Name = "Ocjenalabel";
            this.Ocjenalabel.Size = new System.Drawing.Size(41, 13);
            this.Ocjenalabel.TabIndex = 139;
            this.Ocjenalabel.Text = "Ocjena";
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(131, 121);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(265, 20);
            this.txtOcjena.TabIndex = 131;
            // 
            // labelVerzija
            // 
            this.labelVerzija.AutoSize = true;
            this.labelVerzija.Location = new System.Drawing.Point(33, 202);
            this.labelVerzija.Name = "labelVerzija";
            this.labelVerzija.Size = new System.Drawing.Size(38, 13);
            this.labelVerzija.TabIndex = 138;
            this.labelVerzija.Text = "Verzija";
            // 
            // txtMarkaa
            // 
            this.txtMarkaa.Location = new System.Drawing.Point(131, 199);
            this.txtMarkaa.Name = "txtMarkaa";
            this.txtMarkaa.Size = new System.Drawing.Size(265, 20);
            this.txtMarkaa.TabIndex = 133;
            // 
            // Komentarlabel
            // 
            this.Komentarlabel.AutoSize = true;
            this.Komentarlabel.Location = new System.Drawing.Point(25, 163);
            this.Komentarlabel.Name = "Komentarlabel";
            this.Komentarlabel.Size = new System.Drawing.Size(52, 13);
            this.Komentarlabel.TabIndex = 137;
            this.Komentarlabel.Text = "Komentar";
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(131, 160);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(265, 20);
            this.txtKomentar.TabIndex = 132;
            // 
            // frmOcjenaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 332);
            this.Controls.Add(this.lableNazivAplikacije);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.labelKategorija);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.DojamLabel);
            this.Controls.Add(this.Ocjenalabel);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.labelVerzija);
            this.Controls.Add(this.txtMarkaa);
            this.Controls.Add(this.Komentarlabel);
            this.Controls.Add(this.txtKomentar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOcjenaDetalji";
            this.Text = "frmOcjenaDetalji";
            this.Load += new System.EventHandler(this.frmOcjenaDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableNazivAplikacije;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label labelKategorija;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label DojamLabel;
        private System.Windows.Forms.Label Ocjenalabel;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.Label labelVerzija;
        private System.Windows.Forms.TextBox txtMarkaa;
        private System.Windows.Forms.Label Komentarlabel;
        private System.Windows.Forms.TextBox txtKomentar;
    }
}