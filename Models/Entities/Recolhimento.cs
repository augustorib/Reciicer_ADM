using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Recolhimento
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Data do Recolhimento")]
        public DateTime DataRecolhimento  { get; set; }

        public int PontoColetaId { get; set; }
        public int CooperativaId { get; set; }

        public PontoColeta? PontoColeta { get; set; }
        public Cooperativa? Cooperativa { get; set; }

        public ICollection<RecolhimentoMaterial>? RecolhimentoMateriais { get; set; }
        
    }
}