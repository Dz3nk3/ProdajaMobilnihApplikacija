using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Klijents = new HashSet<Klijent>();
            Zaposleniks = new HashSet<Zaposlenik>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int? DrzavaId { get; set; }

        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<Klijent> Klijents { get; set; }
        public virtual ICollection<Zaposlenik> Zaposleniks { get; set; }
    }
}
