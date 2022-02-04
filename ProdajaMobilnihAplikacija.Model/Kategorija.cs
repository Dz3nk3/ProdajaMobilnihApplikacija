using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model
{
    public partial class Kategorija
    {
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }  // moze se ovo iskoristiti umejsto tip-a za sistem preporuke
        public string Oznaka { get; set; }
        public string Opis { get; set; }
    }
}
