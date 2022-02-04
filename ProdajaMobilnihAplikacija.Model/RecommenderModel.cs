using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model
{
    public class RecommenderModel
    {
        public List<Model.Softver> listToRecommend { get; set; }
        public List<Model.Softver> others { get; set; }
    }
}
