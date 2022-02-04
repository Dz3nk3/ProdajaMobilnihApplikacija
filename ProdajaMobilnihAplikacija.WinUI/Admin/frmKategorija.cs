using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMobilnihAplikacija.WinUI.Admin
{
    public partial class frmKategorija : Form
    {
        private readonly APIService _apiService = new APIService("Kategorija");
        public frmKategorija()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KategorijaSearchRequest()
            {
                Naziv = txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Kategorija>>(search);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }

        private void dgvKlijent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private async void frmKategorija_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Kategorija>>(null);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmKategorijaDetalji frm = new frmKategorijaDetalji();
            frm.Show();
        }
    }
}
