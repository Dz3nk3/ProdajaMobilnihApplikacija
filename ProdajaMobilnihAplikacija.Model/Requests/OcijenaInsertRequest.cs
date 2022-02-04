using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class OcijenaInsertRequest
    {
        public int ocjena { get; set; }
        public string Komentar { get; set; }

        public int? SoftverNarudzbaID { get; set; }
        public int? SoftverId { get; set; }
        public int KlijentId { get; set; }
    }
}
