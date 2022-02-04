using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMobilnihAplikacija.WinUI.Admin
{
    public partial class frmZaposlenikDetalji : Form
    {
        private readonly APIService _service = new APIService("Zaposlenik");
        private readonly APIService _servicegrad = new APIService("Grad");
        private readonly APIService _korisnickiNalogService = new APIService("KorisnickiNalog");
        private readonly APIService _fakultetService = new APIService("Fakultet");
        private int? _id = null;
        public frmZaposlenikDetalji(int? ZaposlenikId = null)
        {
            InitializeComponent();
            _id = ZaposlenikId;

        }

        private async void frmZaposlenikDetalji_Load(object sender, EventArgs e)
        {
            //await LoadKorisnickiNalog();
            try
            {
                
                if (_id != null)
                {
                    var zaposlenik = await _service.GetById<Model.Zaposlenik>(_id);
                    var grad = await _servicegrad.GetById<Model.Grad>(zaposlenik.GradId);
                    //var fakultet = await _fakultetService.GetById<Model.Fakultet>(zaposlenik.FakultetID);

                    txtIme.Text = zaposlenik.Ime;
                    txtPrezime.Text = zaposlenik.Prezime;
                    txtEmail.Text = zaposlenik.Email;
                    txtTelefonn.Text = zaposlenik.KontaktBr;
                    txtDatumRodjenja.Text = zaposlenik.DatumRodjenja;
                    txtSpol.Text = zaposlenik.Spol;
                    //if (zaposlenik.KorisnickiNalogId == 100)
                    //    cmbKorisnickiNalog.Text = "Administrator";
                    //if (zaposlenik.KorisnickiNalogId == 101)
                    //    cmbKorisnickiNalog.Text = "Zaposlenik";
                    txtGrad.Text = grad.Naziv;
                    //txtFakultet.Text = fakultet.Naziv;
                    txtKorisnickoIme.Text = zaposlenik.KorisnickoIme;
                    //Aktivan.Checked = (bool)zaposlenik.Aktivan;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Korisnik nema detalja!");
                throw;
            }
        }

        public ObservableCollection<Model.Grad> GradoviList { get; set; } = new ObservableCollection<Model.Grad>();
        public ObservableCollection<Model.Zaposlenik> ZaposleniciList { get; set; } = new ObservableCollection<Model.Zaposlenik>();

        private async Task LoadKorisnickiNalog()
        {
            var result = await _korisnickiNalogService.Get<List<Model.KorisnickiNalog>>(null);
            result.Insert(0, new Model.KorisnickiNalog());
            //cmbKorisnickiNalog.DisplayMember = "TipKorisnickogNaloga";
            //cmbKorisnickiNalog.ValueMember = "KorisnickiNalogId";
            //cmbKorisnickiNalog.DataSource = result;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {
                var ZaposlenikInesrtQuery = new ZaposlenikInsertRequest();
                ZaposlenikInesrtQuery.KorisnickoIme = txtKorisnickoIme.Text;
                ZaposlenikInesrtQuery.Ime = txtIme.Text;
                ZaposlenikInesrtQuery.Prezime = txtPrezime.Text;
                ZaposlenikInesrtQuery.Email = txtEmail.Text;
                ZaposlenikInesrtQuery.KontaktBr = txtTelefonn.Text;
                ZaposlenikInesrtQuery.Spol = txtSpol.Text;
                ZaposlenikInesrtQuery.DatumRodjenja = txtDatumRodjenja.Text;
                //ZaposlenikInesrtQuery.KorisnickiNalogId = 
                //ZaposlenikInesrtQuery.Aktivan = Aktivan.Checked;
                ZaposlenikInesrtQuery.Password = txtPassword.Text;
                ZaposlenikInesrtQuery.PasswordConfirmation = txtPasswordPotvrda.Text;
                ZaposlenikInesrtQuery.GradId = 1;
                ZaposlenikInesrtQuery.KorisnickiNalogId = 1;
                ZaposlenikInesrtQuery.FakultetID = 1;

                await _service.Insert<Model.Zaposlenik>(ZaposlenikInesrtQuery);

                //var idObjekta = cmbKorisnickiNalog.SelectedValue;
                //var gradovi = await _servicegrad.GetById<List<Model.Grad>>(null);

                //var pronadjeniGradID = -1;

                //GradoviList.Clear();
                //foreach (var grad in gradovi)
                //{
                //    GradoviList.Add(grad);
                //}

                //for (int i = 0; i < GradoviList.Count(); i++)
                //{
                //    if (txtGrad.Text == GradoviList[i].Naziv)
                //    {
                //        pronadjeniGradID = (int)GradoviList[i].GradID;
                //    }
                //}

                ////int korisnickiNalogID = -1;
                ////if (cmbKorisnickiNalog.Text == "Administrator")
                ////    korisnickiNalogID = 100;

                ////if (cmbKorisnickiNalog.Text == "Zaposlenik")
                ////    korisnickiNalogID = 101;


                //if (this.ValidateChildren())
                //{

                //    var request = new ZaposlenikInsertRequest()
                //    {
                //        KorisnickoIme = txtKorisnickoIme.Text,
                //        Ime = txtIme.Text,
                //        Prezime = txtPrezime.Text,
                //        Email = txtEmail.Text,
                //        KontaktBr = txtTelefonn.Text,
                //        Spol = txtSpol.Text,
                //        GradId = pronadjeniGradID,
                //        //FakultetID = 
                //        DatumRodjenja = txtDatumRodjenja.Text,
                //        //KorisnickiNalogId = (int)korisnickiNalogID,
                //        Password = txtPassword.Text,
                //        PasswordConfirmation = txtPasswordPotvrda.Text,
                //        Aktivan = Aktivan.Checked

                //    };

                //    var korisnickiNalog = cmbKorisnickiNalog.SelectedValue;



                //    if (_id.HasValue)
                //    {
                //        await _service.Update<Model.Zaposlenik>(_id, request);
                //        MessageBox.Show("Promjena podataka uspješna!");

                //    }
                //    else
                //    {
                //        await _service.Insert<Model.Zaposlenik>(request);
                //        MessageBox.Show("Zaposlenik uspješno dodan!");

                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške!");

                throw;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
