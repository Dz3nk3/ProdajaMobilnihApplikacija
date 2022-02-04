using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Ocjena
    {
        public Ocjena()
        {
            MojSoftvers = new HashSet<MojSoftver>();
        }

        public int OcjenaId { get; set; }
        public int? Ocjena1 { get; set; }
        public string Komentar { get; set; }

        public virtual ICollection<MojSoftver> MojSoftvers { get; set; }
    }
}
