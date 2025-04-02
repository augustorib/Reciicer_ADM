using Reciicer.Models.Entities;

namespace Reciicer.Models.RecolhimentoViewModels
{
    public class RecolhimentoCreateViewModel
    {

        public Recolhimento? Recolhimento { get; set; }
        public IEnumerable<Cooperativa>? Cooperativas { get; set; }
        public IEnumerable<EstoqueMaterial>? EstoqueMateriais { get; set; }
        public IEnumerable<RecolhimentoEstoqueMaterial>? RecolhimentoEstoqueMateriais { get; set; }  = new List<RecolhimentoEstoqueMaterial>();

    }
}