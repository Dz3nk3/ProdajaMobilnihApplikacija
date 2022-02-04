using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public interface IMojSoftverService
    {
        List<Model.MojSoftver> GetAll(MojSoftverSearchRequest request);
        Model.MojSoftver GetById(int id);
        Model.MojSoftver Insert(MojSoftverInsertRequest request);
        Model.MojSoftver Update(int id, MojSoftveUpsertRequest request);
    }
}
