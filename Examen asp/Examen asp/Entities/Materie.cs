using System.Drawing;

namespace Examen_asp.Entities
{
    public class Materie 
    {
        public int Id { get; set; }
        public string Denumire {  get; set; }
        public ICollection<Profesor> Prof { get; set; }
    }
}
