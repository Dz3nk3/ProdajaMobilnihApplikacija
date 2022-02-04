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

namespace ProdajaMobilnihAplikacija.WinUI.Settings
{
    
    public partial class frmSettings : Form
    {
        private readonly APIService _services = new APIService("Zaposlenik");
        private readonly APIService _servicesGrad = new APIService("Grad");
        private int? _id = null;
        private int? _korisnickiNalogId = null;
        public frmSettings(int? UserID = null)
        {
            InitializeComponent();
            _id = UserID;

        }

        private async void frmSettings_Load(object sender, EventArgs e)
        {
            APIService.UserId = 1;
            if (APIService.UserId != null)
            {
                var zaposlenik = await _services.GetById<Model.Zaposlenik>(APIService.UserId);
                var grad = await _servicesGrad.GetById<Model.Grad>(zaposlenik.GradId);

                txtKorisnickoIme.Text = zaposlenik.KorisnickoIme;
                txtIme.Text = zaposlenik.Ime;
                txtPrezime.Text = zaposlenik.Prezime;
                txtEmail.Text = zaposlenik.Email;
                txtTelefon.Text = zaposlenik.KontaktBr;
                txtDatumRodjenja.Text = zaposlenik.DatumRodjenja;
                _korisnickiNalogId = zaposlenik.KorisnickiNalogId;
                txtSpol.Text = zaposlenik.Spol;
                txtGrad.Text = grad.Naziv;
            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            try
            {

                var zaposlenik = await _services.GetById<Model.Zaposlenik>(_id);
                var grad = await _servicesGrad.Get<List<Model.Grad>>(null);

                int upisaniGradId = -1;


                for (int i = 0; i < grad.Count(); i++)
                {
                    if (grad[i].Naziv == txtGrad.Text)
                    {
                        upisaniGradId = (int)grad[i].GradID;
                    }
                }

                if (this.ValidateChildren())
                {
                    var request = new ZaposlenikInsertRequest()
                    {
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Email = txtEmail.Text,
                        KontaktBr = txtTelefon.Text,
                        DatumRodjenja = txtDatumRodjenja.Text,
                        Password = txtPassword.Text,
                        PasswordConfirmation = txtPasswordPotvrda.Text,
                        Spol = txtSpol.Text,
                        KorisnickiNalogId = _korisnickiNalogId,
                        GradId = upisaniGradId,
                        Aktivan = true
                    };

                    if (_id.HasValue)
                    {
                        await _services.Update<Model.Zaposlenik>(_id, request);
                    }
                    else
                    {
                        await _services.Insert<Model.Zaposlenik>(request);
                    }

                    MessageBox.Show("Uspjesno ste promijenili podatke!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske!");
                throw;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtGrad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
