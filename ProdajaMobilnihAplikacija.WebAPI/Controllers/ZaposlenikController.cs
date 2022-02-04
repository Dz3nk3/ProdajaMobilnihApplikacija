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
    public class ZaposlenikController : ControllerBase
    {
        private readonly IZaposlenikService _service;

        public ZaposlenikController(IZaposlenikService service)
        {
            _service = service;
        }

        //[Authorize(Roles = "Administrator")]
        [HttpGet]
        public ActionResult<List<Model.Zaposlenik>> Get([FromQuery] ZaposlenikSearchRequest request)
        {
            return _service.Get(request);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        public Model.Zaposlenik GetById(int id)
        {
            return _service.GetById(id);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        public Model.Zaposlenik Insert(ZaposlenikInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Zaposlenik Update(int id, ZaposlenikInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpPut("UpdateStatus/{id}")]
        public Model.Zaposlenik UpdateStatus(int id, ZaposlenikStatusRequest request)
        {
            return _service.UpdateStatus(id, request);
        }



    }
}
