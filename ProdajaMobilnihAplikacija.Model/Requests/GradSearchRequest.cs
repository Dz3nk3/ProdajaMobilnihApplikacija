using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class GradSearchRequest
    {
        public int? GradId { get; set; }
        public string Naziv { get; set; }
    }
}
