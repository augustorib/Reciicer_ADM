using Reciicer.Models.Entities;

namespace Reciicer.Models.RecolhimentoViewModels
{
    public class RecolhimentoCreateViewModel
    {

        public int PontoColetaId { get; set; }

        public Recolhimento? Recolhimento { get; set; }
        public IEnumerable<Cooperativa>? Cooperativas { get; set; }
        public IEnumerable<MaterialTotais>? MateriaisTotais { get; set; }
        public IEnumerable<RecolhimentoMaterial>? RecolhimentoMateriais { get; set; }  = new List<RecolhimentoMaterial>();

    }
}