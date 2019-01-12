using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TalentsManagerService.Data.Model;
using TalentsManagerService.Services;

namespace TalentsManagerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalentsController : ControllerBase
    {
        private TalentService talentService;

        public TalentsController(TalentService talentService)
        {
            this.talentService = talentService;
        }

        // GET api/talents
        [HttpGet]
        public ActionResult<IEnumerable<Talent>> Get()
        {
            return talentService.GetAll();
        }

        // GET api/talents/5
        [HttpGet("{id}")]
        public ActionResult<Talent> Get(int id)
        {
            return talentService.GetById(id);
        }

        // POST api/talents
        [HttpPost]
        public void Post([FromBody]Talent talent)
        {
            talentService.Create(talent);
        }

        // PUT api/talents/5
        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Talent talent)
        {
            talentService.Update(id, talent);
        }

        // DELETE api/talents/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            talentService.Delete(id);
        }
    }
}
