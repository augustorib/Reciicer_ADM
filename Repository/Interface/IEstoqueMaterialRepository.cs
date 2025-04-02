
using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IEstoqueMaterialRepository
    {
        IEnumerable<EstoqueMaterial> ListarEstoqueMaterial();    
        EstoqueMaterial ObterEstoqueMaterialPorId(int id); 
        IEnumerable<EstoqueMaterial> ObterEstoqueMaterialPorEstoqueId(int estoqueId); 
        void AtualizarEstoqueMaterial (EstoqueMaterial estoqueMaterial);  
        void RegistrarEstoqueMaterial(EstoqueMaterial estoqueMaterial); 
        void ExcluirEstoqueMaterial(int id);
        public IEnumerable<EstoqueMaterial> ObterEstoqueMaterialPorMaterialEstoque(int estoqueId, int materialId);
    }
}