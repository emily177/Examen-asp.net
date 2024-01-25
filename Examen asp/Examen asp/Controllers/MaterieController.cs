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
    public class MaterieController : ControllerBase
    {
        private readonly MaterieContext _materieContext;

        public MaterieController(MaterieContext materie)
        {
            this._materieContext = materie;
        }
        //[EnableCors("AnotherPolicy")]
        [HttpGet]

        public async Task<IEnumerable<Materie>> GetMaterie()
        {
            return await _materieContext.Materie.ToListAsync();
        }





        [HttpPost("Materie")]
        public async Task<ActionResult<Materie>> PostMaterie(Materie s)
        {
            var materie = new Materie()
            {
                Denumire = s.Denumire,
                Prof = s.Prof
            };
            await _materieContext.Materie.AddAsync(materie);
            await _materieContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMaterie), new { id = materie.Id }, materie);
        }

    }
    
}
