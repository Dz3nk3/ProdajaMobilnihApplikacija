using AutoMapper;
using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Analiza, Model.Analiza>();
            CreateMap<Database.Analiza, AnalizaUpsertRequest>().ReverseMap();


            CreateMap<Database.Klijent, Model.Klijent>();
            CreateMap<Database.Klijent, KlijentInsertRequest>().ReverseMap();
            CreateMap<Database.Klijent, KlijentUpdateRequest>().ReverseMap();

            CreateMap<Database.Ocjena, Model.Ocjena>();
            CreateMap<Database.Ocjena, OcjenaUpsertRequest>().ReverseMap();
            CreateMap<Database.Ocjena, OcijenaInsertRequest>().ReverseMap();

            CreateMap<Database.Zaposlenik, Model.Zaposlenik>();
            CreateMap<Database.Zaposlenik, ZaposlenikInsertRequest>().ReverseMap();
            CreateMap<Database.Zaposlenik, ZaposlenikStatusRequest>().ReverseMap();

            CreateMap<Database.Softver, Model.Softver>();
            CreateMap<Database.Softver, SoftverInsertRequest>().ReverseMap();
            CreateMap<Database.Softver, SoftverUpsertRequest>().ReverseMap();
            CreateMap<Database.Softver, SoftverStatusRequest>().ReverseMap();

            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.Grad, GradUpsertRequest>().ReverseMap();

            CreateMap<Database.Kategorija, Model.Kategorija>();
            CreateMap<Database.Kategorija, KategorijaInsertRequest>().ReverseMap();


            CreateMap<Database.Ocjena, Model.Ocjena>();
            CreateMap<Database.Ocjena, OcjenaUpsertRequest>().ReverseMap();

            CreateMap<Database.Racun, Model.Racun>();
            CreateMap<Database.Racun, RacunUpsertRequest>().ReverseMap();


            CreateMap<Database.KorisnickiNalog, Model.KorisnickiNalog>();
            CreateMap<Database.Drzava, Model.Drzava>();


            CreateMap<Database.MojSoftver, Model.MojSoftver>();
            CreateMap<Database.MojSoftver, MojSoftverInsertRequest>().ReverseMap();
            CreateMap<Database.MojSoftver, MojSoftveUpsertRequest>().ReverseMap();


            //CreateMap<Database.Tip, Model.Tip>();

        }
    }
}
