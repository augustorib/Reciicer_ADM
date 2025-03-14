
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class EstoqueMaterial
    {
        [Key]
        public int Id { get; set; }
        public int Quantidade { get; set; }

        public int Peso { get; set; }

        public int EstoqueId { get; set; }

        public int MaterialId { get; set; }


        public Material? Material { get; set; }

        public Estoque? Estoque { get; set; }

    }
}