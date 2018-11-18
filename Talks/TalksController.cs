using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace talks.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TalksController : ControllerBase
    {
        private readonly TalksService talksService;

        public TalksController(TalksService talksService) {
            this.talksService = talksService;
        }
        

        [HttpGet]
        public ActionResult<IEnumerable<Talk>> Get()
        {
            return talksService.Get().ToList();
        }

        // GET api/talks/kotlin
        [HttpGet("{title}")]
        public ActionResult<Talk> Get(string title)
        {
            return talksService.Get(title);
        }

        [HttpPost]
        public void Post([FromBody] string title)
        {
            talksService.Post(title);
        }

        // PUT api/values/5
        [HttpPut("{title}")]
        public void Put(int id, [FromBody] string title)
        {
            talksService.Put(id, title);
        }

        // DELETE api/values/5
        [HttpDelete("{title}")]
        public void Delete(int id)
        {
            talksService.Delete(id);
        }

    }
}
