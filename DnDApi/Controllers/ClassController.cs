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

        public ClassController(ClassCore core) {
            ClassCore = core;
        }

        [HttpGet]
        public ActionResult<List<Class>> GetClasses() {
            return null;
        }

        [HttpGet("{id}")]
        public ActionResult<Class> GetClass(Guid id) {
           
            return null;
        }

        [HttpPut("{id}")]
        public IActionResult PutClass(Guid id, Class model) {
            
            return NoContent();
        }


        [HttpPost]
        public ActionResult<Class> PostClass(Class model) {
            
            return CreatedAtAction("GetClass", new { id = model.Id }, model);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClass(Guid id) {

            return NoContent();
        }
    }
}
