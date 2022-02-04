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
    public class KategorijaController : ControllerBase
    {
        private readonly IKategorijaService _service;

        public KategorijaController(IKategorijaService service)
        {
            _service = service;
        }

        //[Authorize(Roles = "Administrator")]
        [HttpGet]
        public ActionResult<List<Model.Kategorija>> Get([FromQuery] KategorijaSearchRequest request)
        {
            return _service.Get(request);
        }


        [HttpGet("{id}")]
        public Model.Kategorija GetById(int id)
        {
            return _service.GetById(id);
        }


        [HttpPost]
        public Model.Kategorija Insert( KategorijaInsertRequest request)
        {
            return _service.Insert(request);
        }

    }
}
