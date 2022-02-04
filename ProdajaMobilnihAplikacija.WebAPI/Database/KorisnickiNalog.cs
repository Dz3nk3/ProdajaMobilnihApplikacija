using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class KorisnickiNalog
    {
        public KorisnickiNalog()
        {
            Zaposleniks = new HashSet<Zaposlenik>();
        }

        public int KorisnickiNalogId { get; set; }
        public string TipKorisnickogNaloga { get; set; }

        public virtual ICollection<Zaposlenik> Zaposleniks { get; set; }
    }
}
