using AutoMapper;
using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public class TipService : ITipService
    {
        private readonly Prodaja_Mobilnog_SoftveraContext _context;
        private readonly IMapper _mapper;

        public TipService(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Tip> Get()
        {
            var query = _context.Kategorijas.AsQueryable();
           
            var list = query.ToList();

            return _mapper.Map<List<Model.Tip>>(list);
        }
    }
}
