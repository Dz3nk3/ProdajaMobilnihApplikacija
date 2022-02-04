namespace ProdajaMobilnihAplikacija.WinUI.Admin
{
    partial class frmZaposlenik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZaposlenik));
            this.button1 = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBoxVozila = new System.Windows.Forms.GroupBox();
            this.dgvZaposlenik = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ZaposlenikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktBr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxVozila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenik)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(503, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 46);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 107);
            this.txtPretraga.Multiline = true;
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(407, 43);
            this.txtPretraga.TabIndex = 27;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.ForeColor = System.Drawing.Color.White;
            this.btnPrikazi.Image = ((System.Drawing.Image)(resources.GetObject("btnPrikazi.Image")));
            this.btnPrikazi.Location = new System.Drawing.Point(425, 104);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(63, 46);
            this.btnPrikazi.TabIndex = 26;
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBoxVozila
            // 
            this.groupBoxVozila.Controls.Add(this.dgvZaposlenik);
            this.groupBoxVozila.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBoxVozila.Location = new System.Drawing.Point(3, 181);
            this.groupBoxVozila.Name = "groupBoxVozila";
            this.groupBoxVozila.Size = new System.Drawing.Size(752, 310);
            this.groupBoxVozila.TabIndex = 25;
            this.groupBoxVozila.TabStop = false;
            this.groupBoxVozila.Text = "Zaposlenik";
            // 
            // dgvZaposlenik
            // 
            this.dgvZaposlenik.AllowUserToAddRows = false;
            this.dgvZaposlenik.AllowUserToDeleteRows = false;
            this.dgvZaposlenik.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvZaposlenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZaposlenikID,
            this.Ime,
            this.Prezime,
            this.Email,
            this.KontaktBr,
            this.DatumRodjenja,
            this.Spol,
            this.KorisnickoIme});
            this.dgvZaposlenik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZaposlenik.Location = new System.Drawing.Point(3, 16);
            this.dgvZaposlenik.Name = "dgvZaposlenik";
            this.dgvZaposlenik.ReadOnly = true;
            this.dgvZaposlenik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenik.Size = new System.Drawing.Size(746, 291);
            this.dgvZaposlenik.TabIndex = 0;
            this.dgvZaposlenik.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZaposlenik_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 114;
            this.label1.Text = "Trazi...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 63);
            this.panel1.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(215, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 39);
            this.label2.TabIndex = 115;
            this.label2.Text = "Kreatori aplikacija";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(708, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 42);
            this.button2.TabIndex = 114;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Location = new System.Drawing.Point(0, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 22);
            this.panel2.TabIndex = 116;
            // 
            // ZaposlenikID
            // 
            this.ZaposlenikID.DataPropertyName = "ZaposlenikID";
            this.ZaposlenikID.HeaderText = "ZaposlenikID";
            this.ZaposlenikID.Name = "ZaposlenikID";
            this.ZaposlenikID.ReadOnly = true;
            this.ZaposlenikID.Visible = false;
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
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // KontaktBr
            // 
            this.KontaktBr.DataPropertyName = "KontaktBr";
            this.KontaktBr.HeaderText = "KontaktBr";
            this.KontaktBr.Name = "KontaktBr";
            this.KontaktBr.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "DatumRodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "KorisnickoIme";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // frmZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(770, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBoxVozila);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmZaposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmZaposlenik";
            this.Load += new System.EventHandler(this.frmZaposlenik_Load);
            this.groupBoxVozila.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenik)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBoxVozila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvZaposlenik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposlenikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktBr;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
    }
}