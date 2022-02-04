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

namespace ProdajaMobilnihAplikacija.WinUI.Zaposlenik
{
    public partial class frmReport : Form
    {
        private readonly APIService _MojSoftverService = new APIService("MojSoftver");
        private readonly APIService _SoftverService = new APIService("Softver");
        private readonly APIService _ZaposlenikService = new APIService("Zaposlenik");

        public frmReport()
        {
            InitializeComponent();
        }


        private async Task LoadKategorija()
        {
            var result = await _MojSoftverService.Get<List<Model.MojSoftver>>(null);
            result.Insert(0, new Model.MojSoftver());
            cmbKategorija.DisplayMember = "Datum";
            cmbKategorija.ValueMember = "MojSoftverID";
            cmbKategorija.DataSource = result;
        }

        private async void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbKategorija.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await ReportLoad(id);
            }
        }

        private async Task ReportLoad(int kategorijaId)
        {
            var SearchRequest = new MojSoftverSearchRequest()
            {
                SoftverId  = kategorijaId
            };

            var mojSoftver = await _MojSoftverService.Get<List<Model.MojSoftver>>(SearchRequest);

            var MojSfotverList = new List<MojSoftverListWinFrom>();

            for (int i = 0; i < mojSoftver.Count; i++)
            {

                MojSfotverList.Add(new MojSoftverListWinFrom());

                MojSfotverList[i].DatumKupovine = mojSoftver[i].Datum;
                MojSfotverList[i].NazivSoftvera = mojSoftver[i].Softver.Naziv;
                MojSfotverList[i].VerzijaSoftvera = mojSoftver[i].Softver.Verzija;
                MojSfotverList[i].KlijentIme = mojSoftver[i].Klijent.Ime + mojSoftver[i].Klijent.Prezime;
                MojSfotverList[i].KreatorIme = mojSoftver[i].Zaposlenik.Ime + mojSoftver[i].Zaposlenik.Prezime;
                MojSfotverList[i].CijenaSoftvera = mojSoftver[i].Softver.Cijena.ToString();
                MojSfotverList[i].Ocjena = mojSoftver[i].Ocjena.ToString();
                MojSfotverList[i].Komentar = mojSoftver[i].Komentar.ToString();
            }

            //dataGridView1.AutoGenerateColumns = false;

            dataGridView1.DataSource = MojSfotverList;
        }


        private async void frmReport_Load(object sender, EventArgs e)
        {
            await LoadKategorija();


            APIService.UserId = 1;

            var zaposlenik = await _ZaposlenikService.GetById<Model.Zaposlenik>(APIService.UserId);

            var mojSoftverSearch = new MojSoftverSearchRequest();
            mojSoftverSearch.ZaposlenikId = zaposlenik.ZaposlenikId;

            var mojSoftver = await _MojSoftverService.Get<List<Model.MojSoftver>>(mojSoftverSearch);


            //var softver = await _SoftverService.Get<List<Model.Softver>>(null);

            //var result = mojSoftver;

            //for (int i = 0; i < mojSoftver.Count; i++)
            //{
            //    for (int j = 0; j < mojSoftver.Count; j++)
            //    {
            //        if (mojSoftver[i].SoftverId == mojSoftver[j].SoftverId)
            //        {
            //            result[i].Softver.Cijena += mojSoftver[i].Softver.Cijena;
            //        }
            //    }

            //}

            //int MojSoftverListCount = result.Count;
            var MojSfotverList = new List<MojSoftverListWinFrom>();

            for (int i = 0; i < mojSoftver.Count; i++)
            {

                MojSfotverList.Add(new MojSoftverListWinFrom());

                MojSfotverList[i].DatumKupovine = mojSoftver[i].Datum;
                MojSfotverList[i].NazivSoftvera = mojSoftver[i].Softver.Naziv;
                MojSfotverList[i].VerzijaSoftvera = mojSoftver[i].Softver.Verzija;
                MojSfotverList[i].KlijentIme = mojSoftver[i].Klijent.Ime + mojSoftver[i].Klijent.Prezime;
                MojSfotverList[i].KreatorIme = mojSoftver[i].Zaposlenik.Ime + mojSoftver[i].Zaposlenik.Prezime;
                MojSfotverList[i].CijenaSoftvera = mojSoftver[i].Softver.Cijena.ToString();
                MojSfotverList[i].Ocjena = mojSoftver[i].Ocjena.ToString();
                MojSfotverList[i].Komentar = mojSoftver[i].Komentar.ToString();
            }

            //dataGridView1.AutoGenerateColumns = false;

            dataGridView1.DataSource = MojSfotverList;

        }

        private async void cmbKategorija_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var idObj = cmbKategorija.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await ReportLoad(id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             frmReport_Load(sender, EventArgs.Empty);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmReport_Load(sender, EventArgs.Empty);
        }
    }
}
