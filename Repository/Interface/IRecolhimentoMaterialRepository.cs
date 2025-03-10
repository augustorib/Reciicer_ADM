using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IRecolhimentoMaterialRepository
    {
        IEnumerable<RecolhimentoMaterial> ListarRecolhimentoMaterial();    
        RecolhimentoMaterial ObterRecolhimentoMaterialPorId(int id);  
        void RegistrarRecolhimentoMaterial(RecolhimentoMaterial recolhimentoMaterial); 
        void ExcluirRecolhimentoMaterial(int id);
    }
}