using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model
{
    public partial class Zaposlenik
    {
        public int ZaposlenikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KontaktBr { get; set; }
        public string DatumRodjenja { get; set; }
        public string Spol { get; set; }


        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public string KorisnickoIme { get; set; }
        public int? KorisnickiNalogId { get; set; }
        public bool? Aktivan { get; set; }



        public int? GradId { get; set; }
        public Grad Grad { get; set; }


        public int? FakultetID { get; set; }
        public Fakultet Fakultet { get; set; }


        public virtual KorisnickiNalog KorisnickiNalog { get; set; }



      

    }
}
