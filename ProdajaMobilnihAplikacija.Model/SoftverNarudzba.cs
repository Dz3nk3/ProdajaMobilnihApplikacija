using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model
{
    public partial class SoftverNarudzba
    {
        public int SoftverNarudzbaID { get; set; }
        public int Kolicina { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }

        public int SoftverID { get; set; }
        public Softver Softver { get; set; }


        public int NarudzbaID { get; set; }
        public Narudzba Narudzba { get; set; }

    }
}
