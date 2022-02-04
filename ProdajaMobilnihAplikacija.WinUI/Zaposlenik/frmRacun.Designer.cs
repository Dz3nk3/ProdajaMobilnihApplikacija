namespace ProdajaMobilnihAplikacija.WinUI.Zaposlenik
{
    partial class frmRacun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRacun));
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxVozila = new System.Windows.Forms.GroupBox();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.RacunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NacinPlacanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxVozila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(394, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 28;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxVozila
            // 
            this.groupBoxVozila.Controls.Add(this.dgvRacun);
            this.groupBoxVozila.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBoxVozila.Location = new System.Drawing.Point(5, 85);
            this.groupBoxVozila.Name = "groupBoxVozila";
            this.groupBoxVozila.Size = new System.Drawing.Size(444, 362);
            this.groupBoxVozila.TabIndex = 25;
            this.groupBoxVozila.TabStop = false;
            this.groupBoxVozila.Text = "Racun";
            // 
            // dgvRacun
            // 
            this.dgvRacun.AllowUserToAddRows = false;
            this.dgvRacun.AllowUserToDeleteRows = false;
            this.dgvRacun.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RacunID,
            this.Datum,
            this.Cijena,
            this.Kolicina,
            this.NacinPlacanja});
            this.dgvRacun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRacun.Location = new System.Drawing.Point(3, 16);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.ReadOnly = true;
            this.dgvRacun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacun.Size = new System.Drawing.Size(438, 343);
            this.dgvRacun.TabIndex = 0;
            this.dgvRacun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRacun_CellContentClick);
            // 
            // RacunID
            // 
            this.RacunID.DataPropertyName = "RacunID";
            this.RacunID.HeaderText = "RacunID";
            this.RacunID.Name = "RacunID";
            this.RacunID.ReadOnly = true;
            this.RacunID.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // NacinPlacanja
            // 
            this.NacinPlacanja.DataPropertyName = "NacinPlacanja";
            this.NacinPlacanja.HeaderText = "NacinPlacanja";
            this.NacinPlacanja.Name = "NacinPlacanja";
            this.NacinPlacanja.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 120;
            this.label1.Text = "Racun ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 64);
            this.panel1.TabIndex = 26;
            // 
            // frmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxVozila);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRacun";
            this.Load += new System.EventHandler(this.frmRacun_Load);
            this.groupBoxVozila.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxVozila;
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacunID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn NacinPlacanja;
        private System.Windows.Forms.Panel panel1;
    }
}