using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class KlijentSearchRequest
    {
        public string _Username { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
