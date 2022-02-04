using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model
{
    public partial class Klijent
    {
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTel { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string DatumRodjenja { get; set; }


        public int? GradId { get; set; }
        public Grad Grad { get; set; }


        public int? KarticaID { get; set; }
        public Kartica Kartica { get; set; }

        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public string KorisnickoIme { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}
