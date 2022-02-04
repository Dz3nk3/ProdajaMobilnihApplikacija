using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model
{
    public partial class Racun
    {
        public int RacunID { get; set; }
        public DateTime? DatumPlacanja { get; set; }
        public double Cijena { get; set; }
        public int Kolicina { get; set; }
        public string NacinPlacanja { get; set; }

        //izndano

    }
}
