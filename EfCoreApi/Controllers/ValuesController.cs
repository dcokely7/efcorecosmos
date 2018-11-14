using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        
        /// <summary>
        /// Gets all the UserDocs
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("user")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(UserDoc[]))]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(_context.UserDocs.Where(entry => entry.Name != null));
            
        }

        /// <summary>
        /// Gets all the CarDocs
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("car")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type=typeof(CarDoc[]))]
        public async Task<IActionResult> GetCars()
        {
            return Ok(_context.CarDocs.Where(entry => entry.Model != null));
        }

        /// <summary> 
        /// Gets a set of CarDocs by make
        /// </summary>
        /// <param name="make"></param>
        /// <returns></returns>
        [HttpGet()]
        [Route("car/{make}")]
        public ActionResult<string> GetCarByMake([FromRoute] string make)
        {
            return Ok(_context.CarDocs.Where(car => car.Make == make));
        }

        /// <summary>
        /// Posts a UserDoc
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("user")]
        public async Task<IActionResult> PostUser([FromBody] UserDoc value)
        {
            _context.UserDocs.Add(value);
            await _context.SaveChangesAsync();
            return Ok();
        }

        /// <summary>
        /// Posts a CarDoc
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("car")]
        public async Task<IActionResult> PostCar([FromBody] CarDoc value)
        {
            _context.CarDocs.Add(value);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
