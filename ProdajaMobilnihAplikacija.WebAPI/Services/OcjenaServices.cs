using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public class OcjenaServices : IOcjenaService
    {
        private readonly Prodaja_Mobilnog_SoftveraContext _context;
        private readonly IMapper _mapper;

        public OcjenaServices(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Ocjena> Get(OcjenaSearchRequest search)
        {
            //var query = _context.Set<Ocjena>().AsQueryable();
            var query = _context.Ocjenas.AsQueryable();

           

            //if (search?.ocjena.HasValue == true)
            //{
            //    query = query.Where(x => x.ocjena == search.ocjena);
            //}
            //query = query.OrderBy(x => x.ocjena);

            var list = query.ToList();

            return _mapper.Map<List<Model.Ocjena>>(list);
        }

        public Model.Ocjena Insert(OcjenaUpsertRequest request)
        {
            var query = _mapper.Map<Database.Ocjena>(request);

            _context.Add(query);
            _context.SaveChanges();

            return _mapper.Map<Model.Ocjena>(query);
        }

     
    }
}
