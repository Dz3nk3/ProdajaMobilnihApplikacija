namespace ProdajaMobilnihAplikacija.WinUI.Zaposlenik
{
    partial class frmKlijent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKlijent));
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBoxVozila = new System.Windows.Forms.GroupBox();
            this.dgvKlijent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.KlijentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxVozila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(706, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 28;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(19, 101);
            this.txtPretraga.Multiline = true;
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(443, 43);
            this.txtPretraga.TabIndex = 27;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.ForeColor = System.Drawing.Color.White;
            this.btnPrikazi.Image = ((System.Drawing.Image)(resources.GetObject("btnPrikazi.Image")));
            this.btnPrikazi.Location = new System.Drawing.Point(468, 98);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(62, 46);
            this.btnPrikazi.TabIndex = 26;
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBoxVozila
            // 
            this.groupBoxVozila.Controls.Add(this.dgvKlijent);
            this.groupBoxVozila.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBoxVozila.Location = new System.Drawing.Point(16, 150);
            this.groupBoxVozila.Name = "groupBoxVozila";
            this.groupBoxVozila.Size = new System.Drawing.Size(749, 321);
            this.groupBoxVozila.TabIndex = 25;
            this.groupBoxVozila.TabStop = false;
            this.groupBoxVozila.Text = "Klijent";
            // 
            // dgvKlijent
            // 
            this.dgvKlijent.AllowUserToAddRows = false;
            this.dgvKlijent.AllowUserToDeleteRows = false;
            this.dgvKlijent.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KlijentID,
            this.Ime,
            this.Prezime,
            this.BrojTel,
            this.Email,
            this.Adresa,
            this.DatumRodjenja,
            this.KorisnickoIme});
            this.dgvKlijent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKlijent.Location = new System.Drawing.Point(3, 16);
            this.dgvKlijent.Name = "dgvKlijent";
            this.dgvKlijent.ReadOnly = true;
            this.dgvKlijent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijent.Size = new System.Drawing.Size(743, 302);
            this.dgvKlijent.TabIndex = 0;
            this.dgvKlijent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKlijent_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 120;
            this.label1.Text = "Klijenti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 121;
            this.label2.Text = "Trazi...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 64);
            this.panel1.TabIndex = 122;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(12, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 22);
            this.panel2.TabIndex = 123;
            // 
            // KlijentID
            // 
            this.KlijentID.DataPropertyName = "KlijentID";
            this.KlijentID.HeaderText = "KlijentID";
            this.KlijentID.Name = "KlijentID";
            this.KlijentID.ReadOnly = true;
            this.KlijentID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // BrojTel
            // 
            this.BrojTel.DataPropertyName = "BrojTel";
            this.BrojTel.HeaderText = "BrojTel";
            this.BrojTel.Name = "BrojTel";
            this.BrojTel.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "DatumRodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "KorisnickoIme";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // frmKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(777, 494);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBoxVozila);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKlijent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKlijent";
            this.Load += new System.EventHandler(this.frmKlijent_Load);
            this.groupBoxVozila.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBoxVozila;
        private System.Windows.Forms.DataGridView dgvKlijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
    }
}