using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MojSoftverController : ControllerBase
    {
        private readonly IMojSoftverService _service;

        public MojSoftverController(IMojSoftverService service)
        {
            _service = service;
        }


        [HttpGet]
        public ActionResult<List<Model.MojSoftver>> Get([FromQuery] MojSoftverSearchRequest request)
        {
            return _service.GetAll(request);
        }

        [HttpGet("{id}")]
        public ActionResult<Model.MojSoftver> GetById(int id)
        {
            return _service.GetById(id);
        }


        [HttpPost]
        public Model.MojSoftver Insert(MojSoftverInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.MojSoftver Update(int id, MojSoftveUpsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
