namespace ProdajaMobilnihAplikacija.WinUI.Settings
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpol = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswordPotvrda = new System.Windows.Forms.TextBox();
            this.Potvrda = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.DatumRodjenja = new System.Windows.Forms.Label();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 470);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 89;
            this.label3.Text = "Grad";
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(159, 470);
            this.txtGrad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(352, 22);
            this.txtGrad.TabIndex = 74;
            this.txtGrad.TextChanged += new System.EventHandler(this.txtGrad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 427);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 88;
            this.label2.Text = "Spol";
            // 
            // txtSpol
            // 
            this.txtSpol.Location = new System.Drawing.Point(159, 427);
            this.txtSpol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSpol.Name = "txtSpol";
            this.txtSpol.Size = new System.Drawing.Size(352, 22);
            this.txtSpol.TabIndex = 73;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(455, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 52);
            this.btnExit.TabIndex = 78;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(147, 582);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(223, 57);
            this.btnSnimi.TabIndex = 77;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 52);
            this.label1.TabIndex = 87;
            this.label1.Text = "Postavke profila";
            // 
            // txtPasswordPotvrda
            // 
            this.txtPasswordPotvrda.Location = new System.Drawing.Point(293, 529);
            this.txtPasswordPotvrda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordPotvrda.Name = "txtPasswordPotvrda";
            this.txtPasswordPotvrda.PasswordChar = '*';
            this.txtPasswordPotvrda.Size = new System.Drawing.Size(223, 22);
            this.txtPasswordPotvrda.TabIndex = 76;
            // 
            // Potvrda
            // 
            this.Potvrda.AutoSize = true;
            this.Potvrda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Potvrda.Location = new System.Drawing.Point(289, 510);
            this.Potvrda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Potvrda.Name = "Potvrda";
            this.Potvrda.Size = new System.Drawing.Size(57, 17);
            this.Potvrda.TabIndex = 86;
            this.Potvrda.Text = "Potvrda";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password.Location = new System.Drawing.Point(28, 510);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 85;
            this.Password.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(32, 529);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(223, 22);
            this.txtPassword.TabIndex = 75;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.AutoSize = true;
            this.DatumRodjenja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DatumRodjenja.Location = new System.Drawing.Point(28, 388);
            this.DatumRodjenja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.Size = new System.Drawing.Size(101, 17);
            this.DatumRodjenja.TabIndex = 84;
            this.DatumRodjenja.Text = "Datum rođenja";
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.Location = new System.Drawing.Point(159, 384);
            this.txtDatumRodjenja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(352, 22);
            this.txtDatumRodjenja.TabIndex = 72;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.AutoSize = true;
            this.KorisnickoIme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KorisnickoIme.Location = new System.Drawing.Point(28, 144);
            this.KorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.Size = new System.Drawing.Size(99, 17);
            this.KorisnickoIme.TabIndex = 83;
            this.KorisnickoIme.Text = "Korisničko ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(159, 140);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(352, 22);
            this.txtKorisnickoIme.TabIndex = 67;
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Telefon.Location = new System.Drawing.Point(28, 337);
            this.Telefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(56, 17);
            this.Telefon.TabIndex = 82;
            this.Telefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(159, 334);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(352, 22);
            this.txtTelefon.TabIndex = 71;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Email.Location = new System.Drawing.Point(28, 292);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 81;
            this.Email.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(159, 288);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(352, 22);
            this.txtEmail.TabIndex = 70;
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Prezime.Location = new System.Drawing.Point(28, 239);
            this.Prezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(59, 17);
            this.Prezime.TabIndex = 80;
            this.Prezime.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(159, 235);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(352, 22);
            this.txtPrezime.TabIndex = 69;
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ime.Location = new System.Drawing.Point(28, 192);
            this.Ime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(30, 17);
            this.Ime.TabIndex = 79;
            this.Ime.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(159, 188);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(352, 22);
            this.txtIme.TabIndex = 68;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(540, 667);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpol);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswordPotvrda);
            this.Controls.Add(this.Potvrda);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.DatumRodjenja);
            this.Controls.Add(this.txtDatumRodjenja);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpol;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordPotvrda;
        private System.Windows.Forms.Label Potvrda;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label DatumRodjenja;
        private System.Windows.Forms.TextBox txtDatumRodjenja;
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