using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Zaposlenik
    {
        public Zaposlenik()
        {
            MojSoftvers = new HashSet<MojSoftver>();
            Softvers = new HashSet<Softver>();
        }

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
        public bool? Aktivan { get; set; }
        public int? GradId { get; set; }
        public int? FakultetId { get; set; }
        public int? KorisnickiNalogId { get; set; }

        public virtual Fakultet Fakultet { get; set; }
        public virtual Grad Grad { get; set; }
        public virtual KorisnickiNalog KorisnickiNalog { get; set; }
        public virtual ICollection<MojSoftver> MojSoftvers { get; set; }
        public virtual ICollection<Softver> Softvers { get; set; }
    }
}
