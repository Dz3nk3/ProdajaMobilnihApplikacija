using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class DrzavaUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
    }
}
