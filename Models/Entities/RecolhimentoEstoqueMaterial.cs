using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class RecolhimentoEstoqueMaterial
    {
        [Key]
        public int Id { get; set; }
        public int RecolhimentoId { get; set; }
        public int EstoqueMaterialId { get; set; }
        [DisplayName("Qnt Recolhida")]
        public int Quantidade { get; set; }
        [DisplayName("(g) Recolhido")]
        public int Peso { get; set; }

        public Recolhimento? Recolhimento { get; set; }
        public EstoqueMaterial? EstoqueMaterial { get; set; }
    }
}