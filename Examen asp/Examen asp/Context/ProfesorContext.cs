using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace Examen_asp.Context
{
    public class ProfesorContext : DbContext
    {

        public ProfesorContext(DbContextOptions<MaterieContext> options) : base(options)
        { }
        public DbSet<Entities.Profesor> Profesor { get; set; }
    }
}

