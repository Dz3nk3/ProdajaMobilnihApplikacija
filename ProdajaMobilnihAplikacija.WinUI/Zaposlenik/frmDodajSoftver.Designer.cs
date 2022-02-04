namespace ProdajaMobilnihAplikacija.WinUI.Zaposlenik
{
    partial class frmDodajSoftver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajSoftver));
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelCijena = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.labelVerzija = new System.Windows.Forms.Label();
            this.txtVerzija = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.labelKategorija = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(420, 83);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(75, 23);
            this.lblNaslov.TabIndex = 90;
            this.lblNaslov.Text = "Softver";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(547, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 84;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCijena.Location = new System.Drawing.Point(310, 243);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(46, 16);
            this.labelCijena.TabIndex = 80;
            this.labelCijena.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(397, 241);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(196, 20);
            this.txtCijena.TabIndex = 64;
            // 
            // labelVerzija
            // 
            this.labelVerzija.AutoSize = true;
            this.labelVerzija.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerzija.Location = new System.Drawing.Point(310, 201);
            this.labelVerzija.Name = "labelVerzija";
            this.labelVerzija.Size = new System.Drawing.Size(50, 16);
            this.labelVerzija.TabIndex = 77;
            this.labelVerzija.Text = "Verzija";
            // 
            // txtVerzija
            // 
            this.txtVerzija.Location = new System.Drawing.Point(397, 202);
            this.txtVerzija.Name = "txtVerzija";
            this.txtVerzija.Size = new System.Drawing.Size(196, 20);
            this.txtVerzija.TabIndex = 63;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaziv.Location = new System.Drawing.Point(314, 165);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(42, 16);
            this.labelNaziv.TabIndex = 74;
            this.labelNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(398, 166);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(196, 20);
            this.txtNaziv.TabIndex = 62;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 124);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(203, 137);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 72;
            this.pictureBox.TabStop = false;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(397, 124);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(197, 21);
            this.cmbKategorija.TabIndex = 60;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodaj.Location = new System.Drawing.Point(34, 293);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(158, 32);
            this.btnDodaj.TabIndex = 59;
            this.btnDodaj.Text = "Dodaj sliku";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(8, 267);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(207, 20);
            this.txtSlikaInput.TabIndex = 58;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(200, 360);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(266, 47);
            this.btnSacuvaj.TabIndex = 82;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // labelKategorija
            // 
            this.labelKategorija.AutoSize = true;
            this.labelKategorija.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKategorija.Location = new System.Drawing.Point(310, 123);
            this.labelKategorija.Name = "labelKategorija";
            this.labelKategorija.Size = new System.Drawing.Size(71, 16);
            this.labelKategorija.TabIndex = 57;
            this.labelKategorija.Text = "Kategorija";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(121, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(345, 45);
            this.label13.TabIndex = 101;
            this.label13.Text = "Dodavanje Softvera";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 102;
            this.label1.Text = "Slika";
            // 
            // frmDodajSoftver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.labelVerzija);
            this.Controls.Add(this.txtVerzija);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.labelKategorija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDodajSoftver";
            this.Text = "frmDodajSoftver";
            this.Load += new System.EventHandler(this.frmDodajSoftver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label labelVerzija;
        private System.Windows.Forms.TextBox txtVerzija;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label labelKategorija;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}