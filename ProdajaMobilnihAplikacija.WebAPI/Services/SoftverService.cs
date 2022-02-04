using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using Rent_A_Car.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProdajaMobilnihAplikacija.WebAPI.RecommendationSystem.Recommander;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public class SoftverService : ISoftverService
    {
        private readonly Prodaja_Mobilnog_SoftveraContext _context;
        private readonly IMapper _mapper;

        public SoftverService(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public  List<Model.Softver> Get(SoftverSearchRequest request)
        {

            var query = _context.Softvers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().StartsWith(request.Naziv.ToLower()));
            }

            if (request.SoftverId != null)
            {
                query = query.Where(x => x.SoftverId == request.SoftverId);
            }

            //if (!string.IsNullOrWhiteSpace(request?.Verzija))
            //{
            //    query = query.Where(x => x.Verzija.ToLower().StartsWith(request.Verzija.ToLower()));
            //}

            var list = query.ToList();


            return _mapper.Map<List<Model.Softver>>(list);
        }


        public Model.Softver GetById(int id)
        {
            var entity = _context.Softvers.Find(id);
            return _mapper.Map<Model.Softver>(entity);
        }


        public Model.Softver Insert(SoftverInsertRequest request)
        {
            var query = _mapper.Map<Database.Softver>(request);

            _context.Add(query);
            _context.SaveChanges();

            return _mapper.Map<Model.Softver>(query);
        }


        public List<Model.Softver> Preporuka(int id)
    {
        RecommenderSystem rc = new RecommenderSystem();

        List<Model.Softver> vozila = new List<Model.Softver>();
        //List<int> p = rc.GetRecomended(id).Select(x => x.Key).ToList();
        //foreach (var SoftverId in p)
        //    if (_context.Softver.Find(SoftverId).Naziv != null)
        //    { //if (!_context.Softver.Find(SoftverId).Ocjenas == false)
        //        p.Remove(SoftverId);
        //    }
        //    else
        //    {
        //        var softver = _context.Softver.Find(SoftverId);
        //        vozila.Add(_mapper.Map<Model.Softver>(softver));
        //    }

        return vozila;
    }

         public Model.Softver UpdateStatus(int id, SoftverStatusRequest request)
    {
        var entity = _context.Softvers.Find(id);
        _context.Softvers.Attach(entity);
        _context.Softvers.Update(entity);

        _mapper.Map(request, entity);

        _context.SaveChanges();

        return _mapper.Map<Model.Softver>(entity);
    }


          public Model.Softver Delete(int id)
    {
        var entity = _context.Softvers.Find(id);
        if (entity == null)
        {
            throw new Exception("Softver ne postoji u bazi!!!");
        }
        _context.Softvers.Remove(entity);
        _context.SaveChanges();
        return _mapper.Map<Model.Softver>(entity);
    }
    }





}


