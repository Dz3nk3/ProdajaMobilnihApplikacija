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
using Flurl.Http;
using Flurl;
//ovo moras dodat i na ostalim formama

namespace ProdajaMobilnihAplikacija.WinUI.Pocetna
{
    public partial class frmPocetna : Form
    {


        private readonly APIService _apiService = new APIService("Zaposlenik");
        //private readonly APIService _servicesKlijent = new APIService("Klijent");
        //private readonly APIService _serviceKorisnickiNalog = new APIService("KorisnickiNalog");
        private int? _id = null;

        public frmPocetna(int? UserID = null)
        {
            InitializeComponent();
            _id = UserID;

            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;
            //this.Opacity = .75;
            ////ovo samo napravi panel transparent
            //this.panel1.BackColor = Color.FromArgb(120, 127, 127, 127);
        }

        private async void frmPocetna_Load(object sender, EventArgs e)
        {
            //_id = 1;

            var zaposlenik = await _apiService.GetById<Model.Zaposlenik>(_id);

            label1.Text = zaposlenik.Ime + " " + zaposlenik.Prezime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPregledSoftvera frm = new frmPregledSoftvera();
            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmKlijent frm = new frmKlijent();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmAnaliza frm = new frmAnaliza();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmRacun frm = new frmRacun();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var id = _id;

            //frmSettings frm = new frmSettings();
            //frm.Show();


            frmReport frm = new frmReport();
            frm.Show();

            //frmSettings frm = new frmSettings(int.Parse(id.ToString()));
            //frm.Show();

        }
    }
}
