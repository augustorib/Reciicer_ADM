

using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Recolhimento_Material
    {
        [Key]
        public int Id { get; set; }
        public int RecolhimentoId { get; set; }
        public int MaterialId { get; set; }
        public int QuantidadeTotal { get; set; }
        public int PesoTotal { get; set; }

        //Navigation
        public Recolhimento? Recolhimento { get; set; }
        public Material? Material { get; set; }

    }
}