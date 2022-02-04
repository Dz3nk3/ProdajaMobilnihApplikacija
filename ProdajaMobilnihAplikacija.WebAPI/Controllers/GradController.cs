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
    public class GradController : ControllerBase
    {
        private readonly IGradService _service;
        public GradController(IGradService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Grad>> Get([FromQuery] GradSearchRequest request) 
        {
            return _service.Get(request);
        }


        [HttpGet("{id}")]
        public Model.Grad GetById(int id)
        {
            return _service.GetById(id);
        }


        [HttpDelete]
        public Model.Grad Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
