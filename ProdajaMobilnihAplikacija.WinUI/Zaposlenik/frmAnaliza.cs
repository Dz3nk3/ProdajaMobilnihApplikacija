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
    public partial class frmAnaliza : Form
    {
        private readonly APIService _MojSoftverService = new APIService("MojSoftver");
        private readonly APIService _zaposlenikService = new APIService("Zaposlenik");
        public frmAnaliza()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private async void frmAnaliza_Load(object sender, EventArgs e)
        {
            //APIService.UserId = 1;

            var mojSoftverSearch = new MojSoftverSearchRequest();
            mojSoftverSearch.ZaposlenikId = APIService.UserId;

            var result = await _MojSoftverService.Get<List<Model.MojSoftver>>(null);



//***************************************************************************************************************
//*********************** Ispis dojmova koji su ostavili za njegove app koje je kreiro  *************************
//***************************************************************************************************************


            //var result2 = await _MojSoftverService.Get<List<Model.MojSoftver>>(null);
            //APIService.UserId = 1;
            ////var zaposlenik = await _zaposlenikService.GetById<Model.Zaposlenik>(APIService.UserId);


            //for (int i = 0; i < result.Count; i++)
            //{
            //    if (result[i].ZaposlenikId == APIService.UserId)
            //    {
            //        result2[i] = result[i];
            //    }
            //}

            dgvAnaliza.AutoGenerateColumns = false;

            dgvAnaliza.DataSource = result;
        }

        private void dgvAnaliza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvAnaliza.SelectedRows[0].Cells[0].Value;

            frmAnalizaDetalji frm = new frmAnalizaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
