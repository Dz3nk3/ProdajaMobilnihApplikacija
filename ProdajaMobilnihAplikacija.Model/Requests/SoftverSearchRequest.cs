using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class SoftverSearchRequest
    {
        public int? SoftverId { get; set; }

        //[Required(AllowEmptyStrings = false)]
        //public string Naziv;

        [Required(AllowEmptyStrings = false)]
        public string KlijentIme;
        public int? KategorijaId { get; set; }
        public int? TipId { get; set; }
        public string Naziv { get; set; }

    }
}
