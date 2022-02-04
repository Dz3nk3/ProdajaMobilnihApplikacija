using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Softver
    {
        public Softver()
        {
            MojSoftvers = new HashSet<MojSoftver>();
        }

        public int SoftverId { get; set; }
        public string Naziv { get; set; }
        public string Verzija { get; set; }
        public double? Cijena { get; set; }
        public int? KategorijaId { get; set; }
        public int? ZaposlenikId { get; set; }
        public byte[] SlikaThumb { get; set; }
        public double? PositiveDifferent { get; set; }
        public string Color { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
        public virtual ICollection<MojSoftver> MojSoftvers { get; set; }
    }
}
