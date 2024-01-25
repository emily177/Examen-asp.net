using Examen_asp.Entities;
using Examen_asp.Context;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using Examen_asp.Repository;

namespace Examen_asp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly ProfesorContext _profContext;

        public ProfesorController(ProfesorContext prof)
        {
            this._profContext = prof;
        }
        //[EnableCors("AnotherPolicy")]
        [HttpGet]

        public async Task<IEnumerable<Profesor>> GetProf()
        {
            return await _profContext.Profesor.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Profesor>> PostProf(Profesor p)
        {
            var prof = new Profesor()
            {
                Tip = p.Tip,
                Nume = p.Nume
            };
            await _profContext.Profesor.AddAsync(prof);
            await _profContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProf),  new { id = prof.Id }, prof);
        }
       

    }

}
