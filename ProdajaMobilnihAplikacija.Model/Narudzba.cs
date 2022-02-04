using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model
{
    public partial class Narudzba
    {
        public int NarudzbaID { get; set; }
        public string Naziv { get; set; }
        public string Datum_narudzbe { get; set; }


        public int KlijentID { get; set; }
        public Klijent Klijent { get; set; }


        public int? RacunID { get; set; }
        public Racun Racun { get; set; }
    }
}
