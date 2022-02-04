using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class GradUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        public int? DrzavaId { get; set; }
    }
}
