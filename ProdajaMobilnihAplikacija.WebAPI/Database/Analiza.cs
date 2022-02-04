using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Analiza
    {
        public int AnalizaId { get; set; }
        public string Naziv { get; set; }
        public string DatumAnalize { get; set; }
        public int? KlijentId { get; set; }
        public int? ZaposlenikId { get; set; }
        public int? SoftverId { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Softver Softver { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
    }
}
