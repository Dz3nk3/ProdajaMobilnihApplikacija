using ProdajaMobilnihAplikacija.Model;
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
    public partial class Ocjene : Form
    {
        private readonly APIService _apiService = new APIService("Ocjena");
        public Ocjene()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new OcjenaSearchRequest()
            {
                Komentar = txtPretraga.Text
            };

            var result = await _apiService.Get<List<Ocjena>>(search);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }

        private void dgvKlijent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvKlijent.SelectedRows[0].Cells[0].Value;

            frmOcjenaDetalji frm = new frmOcjenaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void Ocjene_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Ocjena>>(null);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }
    }
}
