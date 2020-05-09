using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DalPiaz.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DalPiaz.API.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        public DalPiazContexto _context { get; }

        public ValuesController (DalPiazContexto context) {
            this._context = context;

        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get () {
            try
            {
                var results = await _context.Eventos.ToListAsync();
                return Ok(results);
            }
            catch (System.Exception ex)
            {
                
               return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/values/5
        [HttpGet ("{id}")]
        public async Task<IActionResult> Get (int id) {
            
            try
            {
                 return Ok(await _context.Eventos.FirstOrDefaultAsync(x=>x.Id==id));
            }
            catch (System.Exception ex)
            {
                
               return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/values
        [HttpPost]
        public void Post ([FromBody] string value) { }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public void Delete (int id) { }
    }
}