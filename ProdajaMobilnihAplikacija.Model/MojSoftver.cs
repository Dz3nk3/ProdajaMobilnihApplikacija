using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model
{
    public class MojSoftver
    {
        public int MojSoftverId { get; set; }
        public int? KlijentId { get; set; }
        public int? RacunId { get; set; }
        public int? SoftverId { get; set; }
        public int? OcjenaId { get; set; }
        public int? ZaposlenikId { get; set; }
        public string Datum { get; set; }
        public int? Ocjena { get; set; }
        public string Komentar { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Ocjena OcjenaNavigation { get; set; }
        public virtual Racun Racun { get; set; }
        public virtual Softver Softver { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
    }
}
