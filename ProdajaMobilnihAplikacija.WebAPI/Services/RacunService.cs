using AutoMapper;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public class RacunService : IRacunService
    {
        private readonly Prodaja_Mobilnog_SoftveraContext _context;
        private readonly IMapper _mapper;

        public RacunService(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Racun> Get(RacunSearchRequest search)
        {
            var query = _context.Set<Racun>().AsQueryable();
            if (search?.Datum != null)
            {
                query = query.Where(x => x.Datum.ToString() == search.Datum);
            }
            query = query.OrderBy(x => x.Datum);
            var list = query.ToList();

            return _mapper.Map<List<Model.Racun>>(list);
        }

     

        public Model.Racun Insert(RacunUpsertRequest request)
        {
            var query = _mapper.Map<Database.Racun>(request);

            _context.Add(query);
            _context.SaveChanges();

            return _mapper.Map<Model.Racun>(query);

        }

        public Model.Racun UpdateStatus(int id, RacunStatusRequest request)
        {
            var entity = _context.Racuns.Find(id);
            _context.Racuns.Attach(entity);
            _context.Racuns.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Racun>(entity);
        }
    }
}
