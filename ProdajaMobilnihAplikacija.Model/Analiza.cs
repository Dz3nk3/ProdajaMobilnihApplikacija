using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model
{
    public partial class Analiza
    {
        public int AnalizaID { get; set; }
        public string Naziv { get; set; }
        public string Datum_analize { get; set; }

        public int KlijentID { get; set; }
        public Klijent Klijent { get; set; }

        public int ZaposlenikID { get; set; }
        public Zaposlenik Zaposlenik { get; set; } 


        public int SoftverID { get; set; }
        public Softver Softver { get; set; }
    }
}
