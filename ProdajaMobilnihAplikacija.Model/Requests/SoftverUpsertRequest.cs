using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class SoftverUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        public string Verzija { get; set; }


        [Range(0, double.MaxValue)]
        public double? Cijena { get; set; }
        [Required(AllowEmptyStrings = false)]
      
        public int? KategorijaId { get; set; }
       
        public int? TipId { get; set; }
        [Required(AllowEmptyStrings = true)]
        public byte[] SlikaThumb { get; set; }
    }
}
