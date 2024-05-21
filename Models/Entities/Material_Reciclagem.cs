

using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Material_Reciclagem
    {
        [Key]
        public int Id { get; set; }
        
        public int MaterialId { get; set; } 

        public int ReciclagemId { get; set; }

        public int Peso { get; set; }

        public int Quantidade { get; set; }     

        //Navigation 
        public Reciclagem? Reciclagem { get; set; }
        public Material? Material { get; set; }
    }
}