using AutoMapper;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public class FakultetService
         : BaseCRUDService<Model.Fakultet, FakultetSearchRequest, Database.Fakultet, FakultetUpsertRequest, FakultetUpsertRequest>,
        IFakultetService
    {
        public FakultetService(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Fakultet> Get(FakultetSearchRequest search)
        {
            var query = _context.Set<Fakultet>().AsQueryable();
            if (search?.Naziv != null)
            {
                query = query.Where(x => x.Naziv == search.Naziv);
            }
            query = query.OrderBy(x => x.Naziv);
            var list = query.ToList();

            return _mapper.Map<List<Model.Fakultet>>(list);
        }

     
    }
}
