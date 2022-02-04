using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public interface IZaposlenikService 
    {
        List<Model.Zaposlenik> Get(ZaposlenikSearchRequest request);

        Model.Zaposlenik GetById(int id);

        Model.Zaposlenik Insert(ZaposlenikInsertRequest request);

        Model.Zaposlenik Update(int id, ZaposlenikInsertRequest request);

        Model.Zaposlenik Authenticiraj(string username, string pass);

        Model.Zaposlenik UpdateStatus(int id, ZaposlenikStatusRequest request);
    }
}
