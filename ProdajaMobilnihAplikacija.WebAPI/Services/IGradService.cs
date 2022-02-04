using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public interface IGradService
    {
        List<Model.Grad> Get(GradSearchRequest request);

        Model.Grad GetById(int request);

        Model.Grad Delete(int id);
    }
}
