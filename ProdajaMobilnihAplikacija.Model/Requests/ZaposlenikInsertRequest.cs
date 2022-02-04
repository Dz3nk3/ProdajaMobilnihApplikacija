using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class ZaposlenikInsertRequest
    {
        //OVDJE MORA BITI ISTI RASPORED KO U DATABASE KLASI

        //[Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }

        //[EmailAddress]
        //[Required]
        //[MinLength(5)]
        public string Email { get; set; }

        //[Required(AllowEmptyStrings = false)]
        public string KontaktBr { get; set; }

        //[Required]
        public string DatumRodjenja { get; set; }

        public string Spol { get; set; }

        public int? GradId { get; set; }

        public int? FakultetID { get; set; }


        //[Required(AllowEmptyStrings = false)]
        //[MinLength(3)]
        public string Password { get; set; }

        //[Required(AllowEmptyStrings = false)]
        public string PasswordConfirmation { get; set; }

        //[Required(AllowEmptyStrings = false)]
        public string KorisnickoIme { get; set; }

        public int? KorisnickiNalogId { get; set; }
        public bool? Aktivan { get; set; }

    }
}
