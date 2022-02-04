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
    public partial class frmRacun : Form
    {
        private readonly APIService _apiService = new APIService("Racun");

        public frmRacun()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private async void frmRacun_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Racun>>(null);

            dgvRacun.AutoGenerateColumns = false;

            dgvRacun.DataSource = result;
        }

        private void dgvRacun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvRacun.SelectedRows[0].Cells[0].Value;

            frmRacunDetalji frm = new frmRacunDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
