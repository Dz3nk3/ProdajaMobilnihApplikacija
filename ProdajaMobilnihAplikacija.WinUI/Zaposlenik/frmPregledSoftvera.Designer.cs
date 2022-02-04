namespace ProdajaMobilnihAplikacija.WinUI.Zaposlenik
{
    partial class frmPregledSoftvera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledSoftvera));
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBoxVozila = new System.Windows.Forms.GroupBox();
            this.dgvKlijent = new System.Windows.Forms.DataGridView();
            this.SoftverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verzija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxVozila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(295, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 46);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(315, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 22;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(19, 88);
            this.txtPretraga.Multiline = true;
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(195, 46);
            this.txtPretraga.TabIndex = 21;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.ForeColor = System.Drawing.Color.White;
            this.btnPrikazi.Image = ((System.Drawing.Image)(resources.GetObject("btnPrikazi.Image")));
            this.btnPrikazi.Location = new System.Drawing.Point(220, 85);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(69, 46);
            this.btnPrikazi.TabIndex = 20;
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBoxVozila
            // 
            this.groupBoxVozila.Controls.Add(this.dgvKlijent);
            this.groupBoxVozila.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBoxVozila.Location = new System.Drawing.Point(12, 151);
            this.groupBoxVozila.Name = "groupBoxVozila";
            this.groupBoxVozila.Size = new System.Drawing.Size(352, 321);
            this.groupBoxVozila.TabIndex = 19;
            this.groupBoxVozila.TabStop = false;
            this.groupBoxVozila.Text = "Softver";
            // 
            // dgvKlijent
            // 
            this.dgvKlijent.AllowUserToAddRows = false;
            this.dgvKlijent.AllowUserToDeleteRows = false;
            this.dgvKlijent.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoftverID,
            this.Naziv,
            this.Cijena,
            this.Verzija});
            this.dgvKlijent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKlijent.Location = new System.Drawing.Point(3, 16);
            this.dgvKlijent.Name = "dgvKlijent";
            this.dgvKlijent.ReadOnly = true;
            this.dgvKlijent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijent.Size = new System.Drawing.Size(346, 302);
            this.dgvKlijent.TabIndex = 0;
            this.dgvKlijent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlijent_CellDoubleClick);
            // 
            // SoftverID
            // 
            this.SoftverID.DataPropertyName = "SoftverID";
            this.SoftverID.HeaderText = "SoftverID";
            this.SoftverID.Name = "SoftverID";
            this.SoftverID.ReadOnly = true;
            this.SoftverID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Verzija
            // 
            this.Verzija.DataPropertyName = "Verzija";
            this.Verzija.HeaderText = "Verzija";
            this.Verzija.Name = "Verzija";
            this.Verzija.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 120;
            this.label1.Text = "Softver";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 54);
            this.panel1.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 122;
            this.label2.Text = "Trazi...";
            // 
            // frmPregledSoftvera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(374, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBoxVozila);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPregledSoftvera";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPregledSoftvera";
            this.Load += new System.EventHandler(this.frmPregledSoftvera_Load);
            this.groupBoxVozila.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBoxVozila;
        private System.Windows.Forms.DataGridView dgvKlijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verzija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}