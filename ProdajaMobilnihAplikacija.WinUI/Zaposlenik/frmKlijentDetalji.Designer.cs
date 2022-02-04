namespace ProdajaMobilnihAplikacija.WinUI.Admin
{
    partial class frmKlijentDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKlijentDetalji));
            this.btnExit = new System.Windows.Forms.Button();
            this.lbNaslov = new System.Windows.Forms.Label();
            this.DatumRodjenja = new System.Windows.Forms.Label();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
            this.Adresa = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.KorisnickoIme = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Prezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(350, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 52;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbNaslov
            // 
            this.lbNaslov.AutoSize = true;
            this.lbNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaslov.Location = new System.Drawing.Point(60, 9);
            this.lbNaslov.Name = "lbNaslov";
            this.lbNaslov.Size = new System.Drawing.Size(232, 39);
            this.lbNaslov.TabIndex = 57;
            this.lbNaslov.Text = "Detalji klijenta";
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.AutoSize = true;
            this.DatumRodjenja.Location = new System.Drawing.Point(34, 368);
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.Size = new System.Drawing.Size(77, 13);
            this.DatumRodjenja.TabIndex = 56;
            this.DatumRodjenja.Text = "Datum rođenja";
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.Location = new System.Drawing.Point(132, 365);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(265, 20);
            this.txtDatumRodjenja.TabIndex = 51;
            // 
            // Adresa
            // 
            this.Adresa.AutoSize = true;
            this.Adresa.Location = new System.Drawing.Point(34, 319);
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(40, 13);
            this.Adresa.TabIndex = 55;
            this.Adresa.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(132, 316);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(265, 20);
            this.txtAdresa.TabIndex = 49;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.AutoSize = true;
            this.KorisnickoIme.Location = new System.Drawing.Point(34, 114);
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.KorisnickoIme.TabIndex = 54;
            this.KorisnickoIme.Text = "Korisničko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(132, 111);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(265, 20);
            this.txtKorisnickoIme.TabIndex = 42;
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(34, 276);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(43, 13);
            this.Telefon.TabIndex = 53;
            this.Telefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(132, 273);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(265, 20);
            this.txtTelefon.TabIndex = 48;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(34, 234);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 50;
            this.Email.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(132, 231);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 20);
            this.txtEmail.TabIndex = 46;
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Location = new System.Drawing.Point(34, 191);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(44, 13);
            this.Prezime.TabIndex = 47;
            this.Prezime.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(132, 188);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(265, 20);
            this.txtPrezime.TabIndex = 45;
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(34, 153);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(24, 13);
            this.Ime.TabIndex = 43;
            this.Ime.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(132, 150);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(265, 20);
            this.txtIme.TabIndex = 44;
            // 
            // frmKlijentDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 433);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbNaslov);
            this.Controls.Add(this.DatumRodjenja);
            this.Controls.Add(this.txtDatumRodjenja);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.KorisnickoIme);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.txtIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKlijentDetalji";
            this.Text = "frmKlijentDetalji";
            this.Load += new System.EventHandler(this.frmKlijentDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbNaslov;
        private System.Windows.Forms.Label DatumRodjenja;
        private System.Windows.Forms.TextBox txtDatumRodjenja;
        private System.Windows.Forms.Label Adresa;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label KorisnickoIme;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.TextBox txtIme;
    }
}