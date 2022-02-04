using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMobilnihAplikacija.WinUI.Zaposlenik
{
    public partial class frmDodajSoftver : Form
    {
        private readonly APIService _SoftverService = new APIService("Softver");
        private readonly APIService _kategorijaService = new APIService("Kategorija");
        private readonly APIService _specifikacijaService = new APIService("Specifikacija");
        private readonly APIService _tipVozila = new APIService("Tip");

        public frmDodajSoftver()
        {
            InitializeComponent();
        }

        private async void frmDodajSoftver_Load(object sender, EventArgs e)
        {
            await LoadKategorija();
        }


        private async Task LoadKategorija()
        {
            var result = await _kategorijaService.Get<List<Model.Kategorija>>(null);
            result.Insert(0, new Model.Kategorija());
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "KategorijaID";
            cmbKategorija.DataSource = result;
        }
        private async Task LoadSpecifikacija()
        {

        }
        private async Task LoadTipVozila()
        {
            var result = await _tipVozila.Get<List<Model.Tip>>(null);
            result.Insert(0, new Model.Tip());
            //cmbTip.DisplayMember = "Naziv";
            //cmbTip.ValueMember = "TipId";
            //cmbTip.DataSource = result;
        }


        private async void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbKategorija.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadVozila(id);
            }
        }

        private async Task LoadVozila(int kategorijaId)
        {
            var result = await _SoftverService.Get<List<Model.Softver>>(new SoftverSearchRequest()
            {
                KategorijaId = kategorijaId
            });
        }


        SoftverUpsertRequest request = new SoftverUpsertRequest();

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                    //unos softvera
                    var request = new SoftverInsertRequest();
                    request.Naziv = txtNaziv.Text;
                    request.Verzija = txtVerzija.Text;
                    request.Cijena = Convert.ToDouble(txtCijena.Text); // pretvoriti string u double?
                    request.KategorijaId = cmbKategorija.SelectedIndex;
                //request.TipId = _tipId
                    request.SlikaThumb = file2;



                var result = await _SoftverService.Insert<Softver>(request);

                MessageBox.Show("Uspjesno ste dodali softver!");
                //}
            }
            catch (Exception ex)
            { 

                MessageBox.Show("Doslo je do greske!");
            }
            this.Close();
        }

        public byte[] file2 = null;
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "jpg files(*.jpg)|*.jpg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                file2 = Encoding.ASCII.GetBytes(openFileDialog1.FileName);
                request.SlikaThumb = file2;
                txtSlikaInput.Text = openFileDialog1.FileName;
                Image image = Image.FromFile(openFileDialog1.FileName);
                pictureBox.Image = image;

                MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Jpeg);
                file2 = ms.ToArray();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
