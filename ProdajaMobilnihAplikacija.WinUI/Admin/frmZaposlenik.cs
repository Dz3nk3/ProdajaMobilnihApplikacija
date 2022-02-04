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
    public partial class frmZaposlenik : Form
    {
        private readonly APIService _apiService = new APIService("Zaposlenik");

        public frmZaposlenik()
        { 
            InitializeComponent();
        }
         
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new ZaposlenikSearchRequest()
            {
                Ime = txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Zaposlenik>>(search);

            dgvZaposlenik.AutoGenerateColumns = false;

            dgvZaposlenik.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmZaposlenikDetalji frm = new frmZaposlenikDetalji();
            frm.Show();
        }

        private void dgvZaposlenik_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvZaposlenik.SelectedRows[0].Cells[0].Value;

            frmZaposlenikDetalji frm = new frmZaposlenikDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmZaposlenik_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Zaposlenik>>(null);

            dgvZaposlenik.AutoGenerateColumns = false;

            dgvZaposlenik.DataSource = result;
        }
    }
}
