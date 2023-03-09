using DnDApi.Core.Source;
using DnDApi.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace DnDApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        private RaceCore RaceCore { get; }

        public RaceController(RaceCore race)
        {
            RaceCore = race;
        }

        [HttpGet]
        public JsonResult List()
        {
            return new JsonResult(RaceCore.List());
        }

        [HttpGet("{id:Guid}")]
        public JsonResult Get(Guid id)
        {
            return new JsonResult(RaceCore.Get(id));
        }

        [HttpPost]
        public JsonResult Post(Race model)
        {
            return new JsonResult(RaceCore.Insert(model));
        }

        [HttpPut("{id:Guid}")]
        public void Put(Guid id, Race model)
        {
            if(model.Id != id)
                throw new InvalidOperationException();

            RaceCore.Update(model);
        }

        [HttpDelete("{id:Guid}")]
        public void Delete(Guid id)
        {
            RaceCore.Delete(id);
        }
    }
}
