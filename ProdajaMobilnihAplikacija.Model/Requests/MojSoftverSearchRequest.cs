using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class MojSoftverSearchRequest
    {
        public int? SoftverId { get; set; }
        public int? ZaposlenikId { get; set; }
        public int? KlijentId { get; set; }
        public int? RacunId { get; set; }
        public int? OcjenaId { get; set; }
        public string Datum { get; set; }
    }
}
