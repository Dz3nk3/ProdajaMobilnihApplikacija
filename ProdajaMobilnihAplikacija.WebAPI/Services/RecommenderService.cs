using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public class RecommenderService : IRecommenderService
    {
        private readonly Prodaja_Mobilnog_SoftveraContext _context;
        private readonly IMapper _mapper;
        public RecommenderService(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List <Model.Softver> Get(int id)
        {
            var SoftverRecomended = _context.MojSoftvers
                .Include(x => x.Klijent)
                .Include(x => x.Softver)
                .ThenInclude(x => x.Kategorija)
                .Where(x => x.Klijent.KlijentId == id)
                .First();

            var slicneAplikacijePoKategoriji = _context.Softvers.Include(x => x.Kategorija).Where(x => x.KategorijaId == x.KategorijaId).ToList();
            var slicneAplikacijePoKategoriji2 = _context.Softvers.Include(x => x.Kategorija).Where(x => x.KategorijaId == x.KategorijaId).ToList();
            //model.listToRecommend = _mapper.Map<List<Model.Softver>>(slicneAplikacijePoKategoriji);

            int brojac = 0;

            for (int i = 0; i < slicneAplikacijePoKategoriji.Count; i++)
            {
                if (slicneAplikacijePoKategoriji[i].Kategorija != null)
                {
                    if (slicneAplikacijePoKategoriji[i].Kategorija.Naziv == SoftverRecomended.Softver.Kategorija.Naziv)
                    {
                        slicneAplikacijePoKategoriji2[brojac] = slicneAplikacijePoKategoriji[i];
                        brojac++;
                    }
                }
            }

            return _mapper.Map<List<Model.Softver>>(slicneAplikacijePoKategoriji2);

            // Slicni softveri
            //var SoftverRecomendedId = SoftverRecomended.MojSoftverId;
            //var slicniSoftver = _context.Softvers.Include(x => x.Kategorija).Where(x => x.Kategorija.Naziv == SoftverRecomended.Softver.Kategorija.Naziv).ToList();
            //model.others = _mapper.Map<List<Model.Softver>>(slicniSoftver);
            
        }

    }
}
