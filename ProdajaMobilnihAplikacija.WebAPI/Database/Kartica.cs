using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Kartica
    {
        public Kartica()
        {
            Klijents = new HashSet<Klijent>();
        }

        public int KarticaId { get; set; }
        public string BrojKartice { get; set; }
        public string Broj { get; set; }

        public virtual ICollection<Klijent> Klijents { get; set; }
    }
}
