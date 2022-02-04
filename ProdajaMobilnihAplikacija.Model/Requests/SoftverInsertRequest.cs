using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class SoftverInsertRequest
    {
        //[Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        public string Verzija { get; set; }


        public double? Cijena { get; set; }

        public int? KategorijaId { get; set; }

        //public int? TipId { get; set; }
        //[Required(AllowEmptyStrings = true)]
        public byte[] SlikaThumb { get; set; }

        public float PositiveDifferent { get; set; }
        public string Color { get; set; }
    }
}
