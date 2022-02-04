using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public interface IKlijentService
    {
        List<Model.Klijent> Get(KlijentSearchRequest request);

        Model.Klijent GetById(int id);

        Model.Klijent Insert(KlijentInsertRequest request);

        Model.Klijent Registracija(KlijentInsertRequest request);


        Model.Klijent Update(int id, KlijentInsertRequest request);

        Model.Klijent Authenticiraj(string username, string pass);
    }
}
