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
    public partial class frmDetaljiSoftvera : Form
    {
        private readonly APIService _serviceSoftver = new APIService("Softver");
        private readonly APIService _servicesTip = new APIService("Tip");
        private readonly APIService _servicesKategorija = new APIService("Kategorija");

        private int? _voziloId = null;
        public frmDetaljiSoftvera(int? voziloId = null)
        {
            InitializeComponent();
            _voziloId = voziloId;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmDetaljiSoftvera_Load(object sender, EventArgs e)
        {
            try
            {
                if (_voziloId.HasValue)
                {
                    var vozilo = await _serviceSoftver.GetById<Model.Softver>(_voziloId);
                    //var tip = await _servicesTip.GetById<Model.Tip>(vozilo.TipId);
                    var kategorija = await _servicesKategorija.GetById<Model.Kategorija>(vozilo.KategorijaId);

                    txtKategorija.Text = kategorija.Naziv;
                    txtKategorija.ReadOnly = true;

                    //txtTipSoftvera.Text = tip.Naziv;
                    //txtTipSoftvera.ReadOnly = true;

                    txtNaziv.Text = vozilo.Naziv;
                    txtNaziv.ReadOnly = true;

                    txtVerzija.Text = vozilo.Verzija;
                    txtVerzija.ReadOnly = true;

                    txtCijena.Text = vozilo.Cijena.ToString();
                    txtCijena.ReadOnly = true;

                    //if (vozilo.Zauzeto != true)
                    //    textZauzeto.Text = "Slobodno";
                    //else
                    //    textZauzeto.Text = "Zauzeto";

                    pictureBox1.Image = Image.FromStream(new MemoryStream(vozilo.SlikaThumb));



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške!");
                throw;
            }
        }
    }
}
