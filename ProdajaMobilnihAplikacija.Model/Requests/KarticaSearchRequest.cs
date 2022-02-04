using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class KarticaSearchRequest
    {
        public int? KarticaID { get; set; }
        public string BrojKartice { get; set; }
    }
}
