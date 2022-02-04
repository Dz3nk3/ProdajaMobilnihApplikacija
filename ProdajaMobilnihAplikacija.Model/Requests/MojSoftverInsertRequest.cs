using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class MojSoftverInsertRequest
    {
        public int? ZaposlenikId { get; set; }
        public int? SoftverId { get; set; }
        public int? KlijentId { get; set; }

        public string Komentar { get; set; }
        public int Ocjena { get; set; }

        public DateTime Datum { get; set; }

    }
}
