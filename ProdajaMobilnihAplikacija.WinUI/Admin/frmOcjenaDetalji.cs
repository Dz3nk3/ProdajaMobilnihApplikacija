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
    public partial class frmOcjenaDetalji : Form
    {
        private readonly APIService _services = new APIService("Ocjena");
        private readonly APIService _servicesSoftver = new APIService("Softver");
        private readonly APIService _servicesUgovor = new APIService("Ugovor");
        private readonly APIService _servicesRezervacija = new APIService("Rezervacija");
        private int? _id = null;
        public frmOcjenaDetalji(int? UgovorId = null)
        {
            InitializeComponent();
            _id = UgovorId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmOcjenaDetalji_Load(object sender, EventArgs e)
        {
            try
            {
                if (_id.HasValue)
                {
                    var ocjena = await _services.GetById<Model.Ocjena>(_id);

                    //var rezervacija = await _servicesRezervacija.GetById<Model.Narudzba>(ocjena.SoftverNarudzbaID);

                    //var vozilo = await _servicesSoftver.GetById<Model.Softver>(ocjena.SoftverID);



                    txtOcjena.Text = ocjena.ocjena.ToString();
                    txtOcjena.ReadOnly = true;
                    txtKomentar.Text = ocjena.Komentar;
                    txtKomentar.ReadOnly = true;

                    //txtModel.Text = vozilo.Verzija;
                    //txtModel.ReadOnly = true;

                    //txtMarkaa.Text = vozilo.KategorijaId.ToString();
                    //txtMarkaa.ReadOnly = true;

                    //txtCijena.Text = rezervacija.Naziv.ToString();
                    //txtCijena.ReadOnly = true;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske!");
                throw;
            }
        }
    }
}
