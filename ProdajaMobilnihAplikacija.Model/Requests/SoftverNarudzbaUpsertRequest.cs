using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class SoftverNarudzbaUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public int SoftverNarudzbaID { get; set; }
        public int Kolicina { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }

        public int SoftverID { get; set; }
        public int NarudzbaID { get; set; }
    }
}
