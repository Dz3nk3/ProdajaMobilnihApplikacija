using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class RacunSearchRequest
    {
        public string Datum { get; set; }
        public double Cijena { get; set; }
        public int Kolicina { get; set; }
        public string NacinPlacanja { get; set; }
    }
}
