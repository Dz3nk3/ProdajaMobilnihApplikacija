using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class DrzavaSearchRequest
    {
        public int? DrzavaID { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }

    }
}
