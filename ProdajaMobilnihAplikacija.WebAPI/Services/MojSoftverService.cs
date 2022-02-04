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
    public class MojSoftverService:IMojSoftverService
    {
        private readonly Prodaja_Mobilnog_SoftveraContext _context;
        private readonly IMapper _mapper;

        public MojSoftverService(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.MojSoftver> GetAll(MojSoftverSearchRequest request)
        {
            var query = _context.MojSoftvers.Include(x=>x.Softver).Include(x=>x.Klijent).Include(x=>x.Zaposlenik).AsQueryable();

            if (request.SoftverId != null)
            {
                query = query.Where(x => x.SoftverId == request.SoftverId);
            }

            if (request.KlijentId != null)
            {
                query = query.Where(x => x.KlijentId == request.KlijentId);
            }

            if (request.ZaposlenikId != null)
            {
                query = query.Where(x => x.ZaposlenikId == request.ZaposlenikId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.MojSoftver>>(list);
        }

        public Model.MojSoftver GetById(int id)
        {
            var entity = _context.MojSoftvers.Find(id);
            //var entity2 = _context.MojSoftvers.Include(x => x.Softver).Include(x => x.Klijent).Where(x => x.MojSoftverId == entity.MojSoftverId).AsQueryable();

            return _mapper.Map<Model.MojSoftver>(entity);
        }

        public Model.MojSoftver Insert(MojSoftverInsertRequest request)
        {
            var entity = _mapper.Map<Database.MojSoftver>(request);

            entity.Datum = DateTime.Now.ToString();

            _context.MojSoftvers.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.MojSoftver>(entity);
        }

        public Model.MojSoftver Update(int id, MojSoftveUpsertRequest request)
        {
            var entity = _context.MojSoftvers.Find(id);

            if (entity.SoftverId != 0 && entity.KlijentId != 0)
            {
                if (entity.Komentar == null && entity.Ocjena == 0)
                {
                    entity.Komentar = request.Komentar;
                    entity.Ocjena = request.Ocjena;

                    _mapper.Map(request, entity);
                    _context.SaveChanges();
                }
                else if (entity.Komentar != null || entity.Ocjena != null)
                {
                    entity.Komentar = request.Komentar;
                    entity.Ocjena = request.Ocjena;

                    _mapper.Map(request, entity);
                    _context.SaveChanges();
                }
            }

            


            return _mapper.Map<Model.MojSoftver>(entity);
        }
    }
}
