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

namespace ProdajaMobilnihAplikacija.WinUI.Zaposlenik
{
    public partial class frmPregledSoftvera : Form
    {
        private readonly APIService _apiService = new APIService("Softver");
        public frmPregledSoftvera()
        {
            InitializeComponent();
        }

        private void btnKalendar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDodajSoftver frm = new frmDodajSoftver();
            frm.Show();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new SoftverSearchRequest();
            search.Naziv = txtPretraga.Text;

            var result = await _apiService.Get<List<Model.Softver>>(search);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmPregledSoftvera_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Softver>>(null);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }

        private void dgvKlijent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvKlijent.SelectedRows[0].Cells[0].Value;

            frmDetaljiSoftvera frm = new frmDetaljiSoftvera(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
