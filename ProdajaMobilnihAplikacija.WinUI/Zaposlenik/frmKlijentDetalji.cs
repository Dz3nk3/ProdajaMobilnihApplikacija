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
    public partial class frmKlijentDetalji : Form
    {
        private readonly APIService _service = new APIService("klijent");
        private int? _id = null;
        public frmKlijentDetalji(int? klijentId = null)
        {
            InitializeComponent();
            _id = klijentId;
        }

        private async void frmKlijentDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var klijent = await _service.GetById<Model.Klijent>(_id);

                txtKorisnickoIme.Text = klijent.KorisnickoIme;
                txtKorisnickoIme.ReadOnly = true;
                txtIme.Text = klijent.Ime;
                txtIme.ReadOnly = true;
                txtPrezime.Text = klijent.Prezime;
                txtPrezime.ReadOnly = true;
                txtEmail.Text = klijent.Email;
                txtEmail.ReadOnly = true;
                txtAdresa.Text = klijent.Adresa;
                txtAdresa.ReadOnly = true;
                txtTelefon.Text = klijent.BrojTel;
                txtTelefon.ReadOnly = true;
                txtDatumRodjenja.Text = klijent.DatumRodjenja;
                txtDatumRodjenja.ReadOnly = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
