using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Drzava
    {
        public Drzava()
        {
            Grads = new HashSet<Grad>();
        }

        public int DrzavaId { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }

        public virtual ICollection<Grad> Grads { get; set; }
    }
}
