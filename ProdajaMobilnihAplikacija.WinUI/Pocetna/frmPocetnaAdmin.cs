using ProdajaMobilnihAplikacija.WinUI.Admin;
using ProdajaMobilnihAplikacija.WinUI.Login;
using ProdajaMobilnihAplikacija.WinUI.Settings;
using ProdajaMobilnihAplikacija.WinUI.Zaposlenik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMobilnihAplikacija.WinUI.Pocetna
{
    public partial class frmPocetnaAdmin : Form
    {

        private int? _id = null;
        private readonly APIService _apiService = new APIService("Zaposlenik");
        public frmPocetnaAdmin(int? UserID = null)
        {
            _id = UserID;
            InitializeComponent();
            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmZaposlenik frm = new frmZaposlenik();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmKategorija frm = new frmKategorija();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmGrad frm = new frmGrad();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ocjene frm = new Ocjene();
            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private async void frmPocetnaAdmin_Load(object sender, EventArgs e)
        {
            //var _id = 2;

            var zaposlenik = await _apiService.GetById<Model.Zaposlenik>(_id);

            label1.Text = zaposlenik.Ime + " " + zaposlenik.Prezime;
        }
    }
}
