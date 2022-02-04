//using ProdajaMobilnihAplikacija.Model.Requests;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

using ProdajaMobilnihAplikacija.Model.Requests;
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

namespace ProdajaMobilnihAplikacija.WinUI.Admin
{
    public partial class frmGradDetalji : Form
    {

        private readonly APIService _service = new APIService("Grad");
        private readonly APIService _serviceDrzava = new APIService("Drzava");


        private readonly APIService _SoftverService = new APIService("Softver");
        private readonly APIService _MojSoftverService = new APIService("MojSoftver");
        private readonly APIService _KlijentService = new APIService("Klijent");
        private readonly APIService _ZaposlenikService = new APIService("Zaposlenik");
        private readonly APIService _KategorijaService = new APIService("Kategorija");

        

        private int? _id = null;
        public frmGradDetalji(int? gradId = null)
        {
            InitializeComponent();
            _id = gradId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async Task LoadDrzava()
        {
            if (_id.HasValue)
            {
                //var mojSoftver = await _MojSoftverService.GetById<Model.MojSoftver>(_id);
                //var MojSoftverPronadji = new MojSoftverSearchRequest();
                //MojSoftverPronadji.SoftverId = _id;
                //var mojSoftver = await _MojSoftverService.Get<List<Model.MojSoftver>>(MojSoftverPronadji);
                //var mojSoftver2 = new Model.MojSoftver();

                //for (int i = 0; i < mojSoftver.Count; i++)
                //{
                //    if (_id == mojSoftver[i].SoftverId)
                //    {
                //        mojSoftver2 = mojSoftver[i];
                //    }
                //}

                //if (mojSoftver2 == null )
                //{
                //    MessageBox.Show("Softver nije kupljen!");
                //    this.Close();
                //}

                var softver = await _SoftverService.GetById<Model.Softver>(_id);
                //var klijent = await _KlijentService.GetById<Model.Klijent>(mojSoftver2.KlijentId);
                var zaposlnik = await _ZaposlenikService.GetById<Model.Zaposlenik>(softver.ZaposlenikId);
                var Kategorija = await _KategorijaService.GetById<Model.Kategorija>(softver.KategorijaId);

                textKreator.Text = zaposlnik.Ime + " " + zaposlnik.Prezime;
                textKreator.ReadOnly = true;

                txtNaziv.Text = softver.Naziv;
                txtNaziv.ReadOnly = true;

                txtDatum.Text = softver.Cijena.ToString();
                txtDatum.ReadOnly = true;

                txtSoftver.Text = softver.Verzija;
                txtSoftver.ReadOnly = true;

                txtKlijent.Text = Kategorija.Naziv;
                txtKlijent.ReadOnly = true;

                //textKomentar.Text = mojSoftver2.Komentar;
                //textKomentar.ReadOnly = true;

                pictureBox1.Image = Image.FromStream(new MemoryStream(softver.SlikaThumb));
            }
        }

        private async void frmGradDetalji_Load(object sender, EventArgs e)
        {
            await LoadDrzava();
            //if (_id.HasValue)
            //{

            //    var grad = await _service.GetById<Model.Grad>(_id);
            //    var drzava = await _serviceDrzava.GetById<Model.Drzava>(grad.DrzavaID);
            //    txtNaziv.Text = grad.Naziv;
            //    /*cmbDrzava.DisplayMember = drzava.Naziv;*/
            //}
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateChildren())
                {
                    var drzavaId = 0;
                    //if (cmbDrzava.Text == "Bosna i Hercegovina")
                    //    drzavaId = 100;
                    //else
                    //    drzavaId = 101;

                    //var request = new GradUpsertRequest()
                    //{
                    //    Naziv = txtNaziv.Text,
                    //    DrzavaId = drzavaId
                    //};


                    //if (_id.HasValue)
                    //{
                    //    await _service.Update<Model.Grad>(_id, request);
                    //}
                    //else
                    //{
                    //    await _service.Insert<Model.Grad>(request);
                    //}

                    MessageBox.Show("Uspjesno ste dodali grad!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske!");
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text) && txtNaziv.Text.Length < 3)
            {
                //errorProvider.SetError(Naziv, "Obavezno polje");
                MessageBox.Show("Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("Obavezno polje");
                //errorProvider.SetError(Naziv, null);
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textKomentar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
