using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public interface IRacunService
    {
        List<Model.Racun> Get(RacunSearchRequest request);


        Model.Racun Insert(RacunUpsertRequest request);

        Racun UpdateStatus(int id, RacunStatusRequest request);
    }
}
