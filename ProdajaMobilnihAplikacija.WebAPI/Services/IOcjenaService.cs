using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public interface IOcjenaService
    {
        List<Model.Ocjena> Get(OcjenaSearchRequest request);

        Model.Ocjena Insert(OcjenaUpsertRequest requtest);

    }
}
