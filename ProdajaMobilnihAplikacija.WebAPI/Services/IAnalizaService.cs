using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public interface IAnalizaService
    {
        List<Model.Analiza> Get(AnalizaSearchRequest request);

        Model.Analiza Insert(AnalizaUpsertRequest request);

        //Model.Analiza GetAnalizaByUserID(int id);

        //Analiza UpdateStatus(int id, AnalizaStatusRequest request);
    }
}
