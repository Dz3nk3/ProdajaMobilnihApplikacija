namespace ProdajaMobilnihAplikacija.WinUI.Admin
{
    partial class Ocjene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ocjene));
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKlijent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.OcjenaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.ForeColor = System.Drawing.Color.White;
            this.btnPrikazi.Image = ((System.Drawing.Image)(resources.GetObject("btnPrikazi.Image")));
            this.btnPrikazi.Location = new System.Drawing.Point(170, 83);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(72, 48);
            this.btnPrikazi.TabIndex = 17;
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 91);
            this.txtPretraga.Multiline = true;
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(155, 37);
            this.txtPretraga.TabIndex = 18;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(206, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 16;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKlijent);
            this.groupBox1.Location = new System.Drawing.Point(9, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 292);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ocijene ";
            // 
            // dgvKlijent
            // 
            this.dgvKlijent.AllowUserToAddRows = false;
            this.dgvKlijent.AllowUserToDeleteRows = false;
            this.dgvKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OcjenaID,
            this.ocjena,
            this.Komentar});
            this.dgvKlijent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKlijent.Location = new System.Drawing.Point(3, 16);
            this.dgvKlijent.Name = "dgvKlijent";
            this.dgvKlijent.ReadOnly = true;
            this.dgvKlijent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijent.Size = new System.Drawing.Size(242, 273);
            this.dgvKlijent.TabIndex = 0;
            this.dgvKlijent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlijent_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(77, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ocjene";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 50);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 115;
            this.label2.Text = "Trazi...";
            // 
            // OcjenaID
            // 
            this.OcjenaID.DataPropertyName = "OcjenaID";
            this.OcjenaID.HeaderText = "OcjenaID";
            this.OcjenaID.Name = "OcjenaID";
            this.OcjenaID.ReadOnly = true;
            this.OcjenaID.Visible = false;
            // 
            // ocjena
            // 
            this.ocjena.DataPropertyName = "ocjena";
            this.ocjena.HeaderText = "Ocjena";
            this.ocjena.Name = "ocjena";
            this.ocjena.ReadOnly = true;
            // 
            // Komentar
            // 
            this.Komentar.DataPropertyName = "Komentar";
            this.Komentar.HeaderText = "Komentar";
            this.Komentar.Name = "Komentar";
            this.Komentar.ReadOnly = true;
            // 
            // Ocjene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ocjene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocjene";
            this.Load += new System.EventHandler(this.Ocjene_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKlijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcjenaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komentar;
    }
}