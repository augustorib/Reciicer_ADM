
using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IEstoqueMaterialRepository
    {
        IEnumerable<EstoqueMaterial> ListarEstoqueMaterial();    
        EstoqueMaterial ObterEstoqueMaterialPorId(int id);  
        void AtualizarEstoqueMaterial (EstoqueMaterial estoqueMaterial);  
        void RegistrarEstoqueMaterial(EstoqueMaterial estoqueMaterial); 
        void ExcluirEstoqueMaterial(int id);
        public EstoqueMaterial ObterEstoqueMaterialPorMaterialEstoqueArmazenagem(int estoqueId, int materialId, int armazenagem);
    }
}