using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Services;

namespace ProdajaMobilnihAplikacija.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoftverController : ControllerBase
    {
        private readonly ISoftverService _service;
        public SoftverController(ISoftverService service)
        {
            _service = service;
        }


        [HttpGet]
        public ActionResult<List<Model.Softver>>Get([FromQuery] SoftverSearchRequest request)
        {
            return _service.Get(request);
        }


        [HttpPost]
        public Model.Softver Insert( SoftverInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpGet("{id}")]
        public ActionResult<Model.Softver> GetById(int id)
        {
            return _service.GetById(id);
        }


        [HttpPut("UpdateStatus/{id}")]
        public Model.Softver UpdateStatus(int id, SoftverStatusRequest request)
        {
            return _service.UpdateStatus(id, request);
        }

        // GET: sistem preporuke
        [HttpGet("Preporuka/{id}")]
        public List<Model.Softver> Preporuka(int id)
        {
            return _service.Preporuka(id);
        }

        [HttpDelete]
        public Model.Softver Delete(int id)
        {
            return _service.Delete(id);
        }
    }




}
