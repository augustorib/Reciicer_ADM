using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.Entities
{
    public class Recolhimento
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataRecolhimento  { get; set; }

        public int PontoColetaId { get; set; }
        public int CooperativaId { get; set; }

        public PontoColeta? PontoColeta { get; set; }
        public Cooperativa? Cooperativa { get; set; }

        public ICollection<Recolhimento_Material>? Recolhimento_Materiais { get; set; }
        
    }
}