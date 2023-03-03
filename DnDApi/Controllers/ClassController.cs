using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DnDApi.Core.Source;
using DnDApi.Shared.DTOs;

namespace DnDApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {

        private ClassCore ClassCore { get; }

        public ClassController(ClassCore core)
        {
            ClassCore = core;
        }

        [HttpGet]
        public JsonResult List()
        {
            return new JsonResult(ClassCore.List());
        }

        [HttpGet("{id:Guid}")]
        public JsonResult Get(Guid id)
        {
            return new JsonResult(ClassCore.Get(id));
        }

        [HttpPost]
        public JsonResult Post(Class model)
        {
            return new JsonResult(ClassCore.Insert(model));
        }

        [HttpPut("{id:Guid}")]
        public void Put(Guid id, Class model)
        {
            if(model.Id != id)
                throw new InvalidOperationException();

            ClassCore.Update(model);
        }

        [HttpDelete("{id:Guid}")]
        public void Delete(Guid id)
        {
            ClassCore.Delete(id);
        }
    }
}
