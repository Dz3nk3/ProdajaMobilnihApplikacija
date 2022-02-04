using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class ZaposlenikSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
    }
}
