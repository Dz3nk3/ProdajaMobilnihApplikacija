using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMobilnihAplikacija.WinUI.Zaposlenik
{
    public partial class frmAnalizaDetalji : Form
    {
        private readonly APIService _services = new APIService("Analiza");
        private readonly APIService _servicesKlijent = new APIService("Klijent");
        private readonly APIService _servicesSoftver = new APIService("Softver");

        private readonly APIService _SoftverService = new APIService("Softver");
        private readonly APIService _MojSoftverService = new APIService("MojSoftver");
        private readonly APIService _KlijentService = new APIService("Klijent");

        private int? _id = null;
        public frmAnalizaDetalji(int? MojSoftverID = null)
        {
            InitializeComponent();
            _id = MojSoftverID;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmAnalizaDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var mojSoftver = await _MojSoftverService.GetById<Model.MojSoftver>(_id);
                var softver = await _SoftverService.GetById<Model.Softver>(mojSoftver.SoftverId);
                var klijent = await _KlijentService.GetById<Model.Klijent>(mojSoftver.KlijentId);

                txtNaziv.Text = klijent.Ime + " " + klijent.Prezime;
                txtDatum.ReadOnly = true;

                txtDatum.Text = mojSoftver.Datum;
                txtDatum.ReadOnly = true;

                txtSoftver.Text = softver.Naziv;
                txtSoftver.ReadOnly = true;

                txtKlijent.Text = mojSoftver.Ocjena.ToString();
                txtKlijent.ReadOnly = true;

                textKomentar.Text = mojSoftver.Komentar;
                textKomentar.ReadOnly = true;

                pictureBox1.Image = Image.FromStream(new MemoryStream(softver.SlikaThumb));
            }
        }
    }
}
