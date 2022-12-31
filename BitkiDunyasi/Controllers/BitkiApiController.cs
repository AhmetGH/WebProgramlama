using Microsoft.AspNetCore.Mvc;
using BitkiDunyasi.Migrations;
using BitkiDunyasi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BitkiDunyasi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BitkiApiController : ControllerBase
    {
        ApplicationDbContext k =new ApplicationDbContext();

        // GET: api/<BitkiApiController>
        [HttpGet]
        public async Task<ActionResult<List<Bitki>>> Get()
        {
            var y = await k.Bitkiler.ToListAsync();
            if (y is null)
            {
                return NoContent();
            }
            return y;

        }

        // GET api/<BitkiApiController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bitki>> Get(int id)
        {
            var y = await k.Bitkiler.FirstOrDefaultAsync(x => x.BitkiID == id);
            if (y is null)
            {
                return NoContent();
            }
            return y;
        }

        // POST api/<BitkiApiController>
        [HttpPost]
        public IActionResult Post([FromBody] Bitki b)
        {
            k.Bitkiler.Add(b);
            k.SaveChanges();
            return Ok();
        }

        // PUT api/<BitkiApiController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Bitki b)
        {
            var b1 = k.Bitkiler.FirstOrDefault(x => x.BitkiID == id);
            if (b1 is null)
            {
                return NotFound();
            }
            b1.bitkiAdi = b.bitkiAdi;
            b1.aciklama = b.aciklama;
            b1.Resim = b.Resim;
            k.Update(b1);
            k.SaveChanges();
            return Ok();
        }

        // DELETE api/<BitkiApiController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var b1 = k.Bitkiler.FirstOrDefault(x => x.BitkiID == id);
            if (b1 is null)
            {
                return NotFound();
            }
            /*if (k.Usercomments.Any(x => x.BitkiID == id))
            {
                return NotFound("Bitkiye ait Kitaplar var");
            }*/
            k.Bitkiler.Remove(b1);
            k.SaveChanges();
            return Ok();
        }
    }
}
