using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class NarudzbaUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        public DateTime? DatumNarudzbe { get; set; }

        public int KlijentID { get; set; }
        public int? RacunID { get; set; }

        //moze li se ovdje prebacit svi atributi iz RACUNA

    }
}
