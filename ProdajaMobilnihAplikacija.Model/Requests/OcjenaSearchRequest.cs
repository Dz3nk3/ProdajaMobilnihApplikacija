using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class OcjenaSearchRequest
    {
        public int? ocjena { get; set; }
        public int? KlijentID { get; set; }
        public int? SoftverID { get; set; }
        public string Komentar { get; set; }
    }
}
