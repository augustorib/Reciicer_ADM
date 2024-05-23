
using Reciicer.Models.Entities;

namespace Reciicer.Models
{
    public class ReciclagemReadViewModel
    {
        public Cliente? Cliente { get; set; }
        public Reciclagem? Reciclagem { get; set; }
        public IEnumerable<Material>? Materiais { get; set; }  
        public IEnumerable<Material_Reciclagem>? Materiais_Reciclagem { get; set; }  
        
    }
}