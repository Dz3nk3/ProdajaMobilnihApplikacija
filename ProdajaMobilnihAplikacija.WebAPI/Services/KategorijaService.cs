using AutoMapper;
using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public class KategorijaService : IKategorijaService
    {
        private readonly Prodaja_Mobilnog_SoftveraContext _context;
        private readonly IMapper _mapper;
        public KategorijaService(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Kategorija> Get(KategorijaSearchRequest request)
        {
            var query = _context.Kategorijas.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().StartsWith(request.Naziv.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(request?.Oznaka))
            {
                query = query.Where(x => x.Oznaka.ToLower().StartsWith(request.Oznaka.ToLower()));
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Kategorija>>(list);
        }

        public Model.Kategorija GetById(int id)
        {
            var query = _context.Kategorijas.Find(id);


            return _mapper.Map<Model.Kategorija>(query);
        }

        public Model.Kategorija Insert(KategorijaInsertRequest request)
        {
            var query = _mapper.Map<Database.Kategorija>(request);

            _context.Add(query);
            _context.SaveChanges();

            return _mapper.Map<Model.Kategorija>(query);
        }
    }
}
