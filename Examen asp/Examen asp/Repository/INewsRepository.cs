using Examen_asp.Entities;
using System.Drawing;

namespace Examen_asp.Repository
{
    public interface INewsRepository
    {
        public Task<IEnumerable<Materie>> GetMaterieAsync();
        public Task<Materie> GetMaterieAsync(int id, bool? includeCategories);
        public Task<Materie> PutMaterieAsync(int id, Materie materie);
    }
}

