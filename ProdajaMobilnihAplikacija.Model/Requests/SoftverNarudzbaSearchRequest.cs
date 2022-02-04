using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class SoftverNarudzbaSearchRequest
    {
        public int SoftverNarudzbaID { get; set; }
        public int Kolicina { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public int SoftverID { get; set; }
        public int NarudzbaID { get; set; }
    }
}
