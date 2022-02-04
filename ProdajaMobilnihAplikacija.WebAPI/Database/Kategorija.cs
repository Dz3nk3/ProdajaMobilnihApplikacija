using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Softvers = new HashSet<Softver>();
        }

        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Softver> Softvers { get; set; }
    }
}
