using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WinUI.Admin;
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
    public partial class frmKlijent : Form
    {
        private readonly APIService _apiService = new APIService("Klijent");
        private readonly APIService _MojSoftverService = new APIService("MojSoftver");


        public frmKlijent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KlijentSearchRequest()
            {
                Ime = txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Klijent>>(search);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }

        private void dgvKlijent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKlijent.SelectedRows[0].Cells[0].Value;

            frmKlijentDetalji frm = new frmKlijentDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void frmKlijent_Load(object sender, EventArgs e)
        {

            //APIService.UserId = 1;
            var result = await _apiService.Get<List<Model.Klijent>>(null);
            //var resultKlijent = new List<Model.Klijent>();

            //var mojSoftver = await _MojSoftverService.Get<List<Model.MojSoftver>>(null);

            //for (int i = 0; i < mojSoftver.Count; i++)
            //{
            //    if (mojSoftver[i].ZaposlenikId == APIService.UserId)
            //    {
            //        if (mojSoftver[i].KlijentId == result[i].KlijentId)
            //        {
            //            resultKlijent[i] = result[i];
            //        }
            //    }
            //}

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }
    }
}
