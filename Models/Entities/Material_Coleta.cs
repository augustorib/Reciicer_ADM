using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Material_Coleta
    {
        [Key]
        public int Id { get; set; }
        public int Peso { get; set; }
        public int Quantidade { get; set; }     
        public int ColetaId { get; set; }
        public int MaterialId { get; set; }

        //Navigation 
        public Coleta? Coleta { get; set; }
        public Material? Material { get; set; }

    }
}