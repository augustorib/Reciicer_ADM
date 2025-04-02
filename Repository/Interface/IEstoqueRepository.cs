
using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IEstoqueRepository
    {
        IEnumerable<Estoque> ListarEstoque();   
        IEnumerable<Estoque> ListarEstoquePorPontoColetaId(int pontoColetaId);   
        Estoque ObterEstoquePorId(int id);  
        void RegistrarEstoque(Estoque estoque); 
        void AtualizarEstoque(Estoque estoque);
        void ExcluirEstoque(int id);
    }
}