using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.Estoque
{
    public class EstoqueService
    {
        private readonly IEstoqueRepository _estoqueRepository;

        public EstoqueService(IEstoqueRepository estoqueRepository)
        {
            _estoqueRepository = estoqueRepository;
        }

        public IEnumerable<Entities.Estoque> ListarEstoque()
        {
            return _estoqueRepository.ListarEstoque();
        }

        public Entities.Estoque ObterEstoquePorId(int id)
        {
            return _estoqueRepository.ObterEstoquePorId(id);
        }

        public void RegistrarEstoque(Entities.Estoque Estoque)
        {
            _estoqueRepository.RegistrarEstoque(Estoque);
        }
        public void AtualizarEstoque(Entities.Estoque Estoque)
        {
            _estoqueRepository.AtualizarEstoque(Estoque);
        }
        
        public void ExcluirEstoque(int id)
        {
            _estoqueRepository.ExcluirEstoque(id);
        }
    }
}