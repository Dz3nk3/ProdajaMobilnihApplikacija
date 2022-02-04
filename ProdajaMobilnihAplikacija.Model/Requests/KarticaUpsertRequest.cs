using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class KarticaUpsertRequest
    {
        public int KarticaID { get; set; }
        public string BrojKartice { get; set; }
        public string Broj { get; set; }
    }
}
