using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class AnalizaUpsertRequest
    {
        public string Naziv { get; set; }
        public string Datum_analize { get; set; }

        public int KlijentID { get; set; }
        public int ZaposlenikID { get; set; }
        public int SoftverID { get; set; }
    }
}
