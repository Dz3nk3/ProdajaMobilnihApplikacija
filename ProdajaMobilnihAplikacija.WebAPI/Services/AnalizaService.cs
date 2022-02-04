using AutoMapper;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public class AnalizaService : IAnalizaService
    {
        private readonly Prodaja_Mobilnog_SoftveraContext _context;
        private readonly IMapper _mapper;

        public AnalizaService(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public List<Model.Analiza> Get(AnalizaSearchRequest search)
        {
            var query = _context.Set<Analiza>().AsQueryable();
            if (search?.Naziv != null)
            {
                query = query.Where(x => x.Naziv == search.Naziv);
            }
            query = query.OrderBy(x => x.Naziv);
            var list = query.ToList();

            return _mapper.Map<List<Model.Analiza>>(list);
        }

        public Model.Analiza Insert(AnalizaUpsertRequest request)
        {
            var query = _mapper.Map<Database.Analiza>(request);

            _context.Add(query);
            _context.SaveChanges();

            return _mapper.Map<Model.Analiza>(query);
        }

        //public Model.Analiza GetAnalizaByUserID(int id)
        //{
        //    var query = _context.Ocjena.FirstOrDefault(x => x.SoftverNarudzbaId == id);

        //    if (query != null)
        //    {
        //        return _mapper.Map<Model.Analiza>(query);
        //    }
        //    return null;
        //}


        //public Model.Analiza UpdateStatus(int id, AnalizaStatusRequest request)
        //{
        //    var entity = _context.Analiza.Find(id);
        //    _context.Analiza.Attach(entity);
        //    _context.Analiza.Update(entity);

        //    _mapper.Map(request, entity);

        //    _context.SaveChanges();

        //    return _mapper.Map<Model.Analiza>(entity);
        //}
    }
}
