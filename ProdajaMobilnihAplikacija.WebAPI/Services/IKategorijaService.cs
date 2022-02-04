using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public interface IKategorijaService
    {
        List<Model.Kategorija> Get(KategorijaSearchRequest request);

        Model.Kategorija GetById(int id);

        Model.Kategorija Insert(KategorijaInsertRequest request);
    }
}
