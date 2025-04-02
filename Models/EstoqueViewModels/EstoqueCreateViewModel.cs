using Reciicer.Models.Entities;

namespace Reciicer.Models.EstoqueViewModels
{
    public class EstoqueCreateViewModel
    {
        public Estoque? Estoque { get; set; }

        public IEnumerable<PontoColeta>? PontoColetas { get; set; }
    }
}