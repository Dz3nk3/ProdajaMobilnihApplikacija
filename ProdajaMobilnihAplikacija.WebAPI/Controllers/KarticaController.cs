using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Services;

namespace ProdajaMobilnihAplikacija.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KarticaController
          : BaseCRUDController<Kartica, KarticaSearchRequest, KarticaUpsertRequest, KarticaUpsertRequest>
    {
        //private readonly IKarticaService _service;
        public KarticaController(ICRUDService<Kartica, KarticaSearchRequest, KarticaUpsertRequest, KarticaUpsertRequest> service) : base(service)
        {
        }
    }
}
