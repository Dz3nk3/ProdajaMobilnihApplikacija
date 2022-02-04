using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model
{
    public partial class Grad
    {
        public int GradID { get; set; }
        public string Naziv { get; set; }
        public int DrzavaID { get; set; }
        public Drzava Drzava { get; set; }
    }
}
