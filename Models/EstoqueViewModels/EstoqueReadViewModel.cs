using Reciicer.Models.Entities;

namespace Reciicer.Models.EstoqueViewModels
{
    public class EstoqueReadViewModel
    {
        public Estoque? Estoque { get; set; }

        public IEnumerable<EstoqueMaterial>? EstoqueMateriais { get; set; }
    }
}