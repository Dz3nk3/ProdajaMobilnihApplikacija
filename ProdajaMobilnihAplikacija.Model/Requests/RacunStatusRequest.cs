using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class RacunStatusRequest
    {
        public DateTime? DatumPlacanja { get; set; }
        public string NacinPlacanja { get; set; }
    }
}
