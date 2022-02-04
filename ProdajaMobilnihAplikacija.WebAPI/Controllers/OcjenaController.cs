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
    public class OcjenaController : ControllerBase
    {
        private readonly IOcjenaService _service;

        public OcjenaController(IOcjenaService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Ocjena>> Get([FromQuery] OcjenaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Ocjena Insert([FromQuery] OcjenaUpsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
