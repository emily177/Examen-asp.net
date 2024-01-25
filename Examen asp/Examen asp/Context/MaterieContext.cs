using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace Examen_asp.Context
{
    public class MaterieContext : DbContext
    {

        public MaterieContext(DbContextOptions<MaterieContext> options) : base(options)
        { }
        public DbSet<Entities.Materie> Materie { get; set; }
        public DbSet<Entities.Profesor> Profesor { get; set; }
    }
}

