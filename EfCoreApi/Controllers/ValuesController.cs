using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly EfTestContext _context;

        public ValuesController(EfTestContext efTestContext)
        {
            _context = efTestContext;
        }
        // GET api/values
        [HttpGet]
        [Route("user")]
        public async Task<IActionResult> GetUser()
        {
            return Ok(_context.UserDocs.Where(entry => entry.Name != null));
            
        }

        // GET api/values
        [HttpGet]
        [Route("car")]
        public async Task<IActionResult> GetCar()
        {
            return Ok(_context.CarDocs.Where(entry => entry.Model != null));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [Route("user")]
        public async Task<IActionResult> Post([FromBody] UserDoc value)
        {
            _context.UserDocs.Add(value);
            await _context.SaveChangesAsync();
            return Ok();
        }

        // POST api/values
        [HttpPost]
        [Route("car")]
        public async Task<IActionResult> PostCar([FromBody] CarDoc value)
        {
            _context.CarDocs.Add(value);
            await _context.SaveChangesAsync();
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
