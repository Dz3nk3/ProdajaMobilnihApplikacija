using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public interface ISoftverService
    {
        List<Model.Softver> Get(SoftverSearchRequest request);
        Softver Insert(SoftverInsertRequest requestuest);

        Model.Softver GetById(int id);

        Softver UpdateStatus(int id, SoftverStatusRequest request);

        List<Model.Softver> Preporuka(int id);

        Model.Softver Delete(int id);



    }
}
