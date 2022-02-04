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
    public class RacunController : ControllerBase
    {
        private readonly IRacunService _service;

        public RacunController(IRacunService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Racun>> Get([FromQuery] RacunSearchRequest request)
        {
            return _service.Get(request);
        }


        [HttpPost]
        public Model.Racun Insert([FromQuery] RacunUpsertRequest request)
        {
            return _service.Insert(request);
        }

       

        [HttpPut("UpdateStatus/{id}")]
        public Model.Racun UpdateStatus(int id, RacunStatusRequest request)
        {
            return _service.UpdateStatus(id, request);
        }
    }
}
