using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Services;

namespace ProdajaMobilnihAplikacija.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlijentController : ControllerBase
    {
        private readonly IKlijentService _service;
        public KlijentController(IKlijentService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Klijent>> Get([FromQuery] KlijentSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Klijent GetById(int id)
        {
            return _service.GetById(id);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        public Model.Klijent Insert(KlijentInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Klijent Update(int id, KlijentInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [AllowAnonymous]
        [HttpPost("Registracija")]
        public Model.Klijent Registracija(KlijentInsertRequest request)
        {
            return _service.Registracija(request);
        }
    }
}
