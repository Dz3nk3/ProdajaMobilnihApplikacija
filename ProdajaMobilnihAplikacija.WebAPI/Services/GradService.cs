using AutoMapper;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public class GradService : IGradService
    {
        private readonly Prodaja_Mobilnog_SoftveraContext _context;
        private readonly IMapper _mapper;

        public GradService(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public List<Model.Grad> Get(GradSearchRequest request)
        {
            var query = _context.Grads.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().StartsWith(request.Naziv.ToLower()));
            }

           
            var list = query.ToList();
            return _mapper.Map<List<Model.Grad>>(list);
        }


        public Model.Grad Delete(int id)
        {
            var entity = _context.Grads.Find(id);
            if (entity == null)
            {
                throw new Exception("Grad ne postoji u bazi!!!");
            }
            _context.Grads.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Grad>(entity);
        }

        public Model.Grad GetById(int id)
        {
            var query = _context.Grads.Find(id);

            return _mapper.Map<Model.Grad>(query);
        }
    }
}
