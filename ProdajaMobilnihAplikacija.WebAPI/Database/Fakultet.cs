using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Fakultet
    {
        public Fakultet()
        {
            Zaposleniks = new HashSet<Zaposlenik>();
        }

        public int FakultetId { get; set; }
        public string Naziv { get; set; }
        public string Univerzitet { get; set; }

        public virtual ICollection<Zaposlenik> Zaposleniks { get; set; }
    }
}
