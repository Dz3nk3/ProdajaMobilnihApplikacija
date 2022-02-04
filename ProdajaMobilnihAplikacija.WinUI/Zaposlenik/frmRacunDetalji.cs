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
    public partial class frmRacunDetalji : Form
    {
        private readonly APIService _services = new APIService("Racun");
    
        private int? _id = null;
        public frmRacunDetalji(int? UgovorId = null)
        {
            InitializeComponent();
            _id = UgovorId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmRacunDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var racun = await _services.GetById<Model.Racun>(_id);
              
                txtDatumPlacanja.Text = racun.DatumPlacanja.ToString();
                txtCijena.ReadOnly = true;

                txtCijena.Text = racun.Cijena.ToString();
                txtCijena.ReadOnly = true;

                txtKolicina.Text = racun.Kolicina.ToString();
                txtKolicina.ReadOnly = true;

                txtNacinPlacanja.Text = racun.NacinPlacanja;
                txtNacinPlacanja.ReadOnly = true;


            }
        }
    }
}
