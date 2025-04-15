using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Recolhimento : EntidadeBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Data do Recolhimento")]
        public DateTime DataRecolhimento  { get; set; }

        public int CooperativaId { get; set; }

        public Cooperativa? Cooperativa { get; set; }

        public ICollection<RecolhimentoEstoqueMaterial>? RecolhimentoEstoqueMateriais { get; set; }
        
    }
}