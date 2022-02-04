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
    public class AnalizaController : ControllerBase
    {
        private readonly IAnalizaService _service;
        public AnalizaController(IAnalizaService service)
        {
            _service = service;
        }



        [HttpGet]
        public ActionResult<List<Model.Analiza>> Get([FromQuery] AnalizaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Analiza Insert([FromQuery] AnalizaUpsertRequest request)
        {
            return _service.Insert(request);
        }

       
    }
}
