namespace ProdajaMobilnihAplikacija.WinUI.Zaposlenik
{
    partial class frmAnaliza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaliza));
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxAnaliza = new System.Windows.Forms.GroupBox();
            this.dgvAnaliza = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MojSoftverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxAnaliza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnaliza)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(557, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 28;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxAnaliza
            // 
            this.groupBoxAnaliza.Controls.Add(this.dgvAnaliza);
            this.groupBoxAnaliza.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBoxAnaliza.Location = new System.Drawing.Point(5, 91);
            this.groupBoxAnaliza.Name = "groupBoxAnaliza";
            this.groupBoxAnaliza.Size = new System.Drawing.Size(598, 379);
            this.groupBoxAnaliza.TabIndex = 25;
            this.groupBoxAnaliza.TabStop = false;
            this.groupBoxAnaliza.Text = "Analiza";
            // 
            // dgvAnaliza
            // 
            this.dgvAnaliza.AllowUserToAddRows = false;
            this.dgvAnaliza.AllowUserToDeleteRows = false;
            this.dgvAnaliza.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvAnaliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnaliza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MojSoftverID,
            this.ocjena,
            this.Komentar,
            this.Datum});
            this.dgvAnaliza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnaliza.Location = new System.Drawing.Point(3, 16);
            this.dgvAnaliza.Name = "dgvAnaliza";
            this.dgvAnaliza.ReadOnly = true;
            this.dgvAnaliza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnaliza.Size = new System.Drawing.Size(592, 360);
            this.dgvAnaliza.TabIndex = 0;
            this.dgvAnaliza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnaliza_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(171, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 33);
            this.label1.TabIndex = 119;
            this.label1.Text = "Analiza softvera";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 61);
            this.panel1.TabIndex = 26;
            // 
            // MojSoftverID
            // 
            this.MojSoftverID.DataPropertyName = "MojSoftverID";
            this.MojSoftverID.HeaderText = "MojSoftverID";
            this.MojSoftverID.Name = "MojSoftverID";
            this.MojSoftverID.ReadOnly = true;
            this.MojSoftverID.Visible = false;
            // 
            // ocjena
            // 
            this.ocjena.DataPropertyName = "ocjena";
            this.ocjena.HeaderText = "ocjena";
            this.ocjena.Name = "ocjena";
            this.ocjena.ReadOnly = true;
            this.ocjena.Width = 200;
            // 
            // Komentar
            // 
            this.Komentar.DataPropertyName = "Komentar";
            this.Komentar.HeaderText = "Komentar";
            this.Komentar.Name = "Komentar";
            this.Komentar.ReadOnly = true;
            this.Komentar.Width = 250;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // frmAnaliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(615, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxAnaliza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaliza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnaliza";
            this.Load += new System.EventHandler(this.frmAnaliza_Load);
            this.groupBoxAnaliza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnaliza)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxAnaliza;
        private System.Windows.Forms.DataGridView dgvAnaliza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MojSoftverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
    }
}