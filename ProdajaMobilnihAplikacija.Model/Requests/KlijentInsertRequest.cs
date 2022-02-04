using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class KlijentInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string KorisnickoIme { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string BrojTel { get; set; }

        [EmailAddress]
        [Required]
        [MinLength(5)]
        public string Email { get; set; }

        public string Adresa { get; set; }
        public string Spol { get; set; }

        [Required]
        public string DatumRodjenja { get; set; }
        public int? GradId { get; set; }
        public int? KarticaID { get; set; }



        //[Required(AllowEmptyStrings = false)]
        //[MinLength(3)]
        public string Password { get; set; }
        //[Required(AllowEmptyStrings = false)]
        public string PasswordConfirmation { get; set; }

    }
}
