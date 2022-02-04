using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdajaMobilnihAplikacija.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommenderController : ControllerBase
    {
        private readonly IRecommenderService _service;
        public RecommenderController(IRecommenderService service)
        {
            _service = service;
        }



        [HttpGet]
        public List<Model.Softver> Get([FromQuery] int id)
        {
            return _service.Get(id);
        }
    }
}
