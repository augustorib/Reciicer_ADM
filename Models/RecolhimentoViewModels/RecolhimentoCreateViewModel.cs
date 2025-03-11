using Reciicer.Models.Entities;

namespace Reciicer.Models.RecolhimentoViewModels
{
    public class RecolhimentoCreateViewModel
    {
        
        public int CooperativaId { get; set; }

        public int PontoColetaId { get; set; }

        public int QuantidadeTotal { get; set; }
        public int PesoTotal { get; set; }

        public Recolhimento? Recolhimento { get; set; }
        public IEnumerable<Cooperativa>? Cooperativas { get; set; }
        public IEnumerable<MaterialTotais>? MateriaisTotais { get; set; }
        public IEnumerable<RecolhimentoMaterial>? RecolhimentoMateriais { get; set; } 
    }
}