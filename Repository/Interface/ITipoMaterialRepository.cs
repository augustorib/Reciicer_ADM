


using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface ITipoMaterialRepository
    {
        IEnumerable<TipoMaterial> ListarTipoMaterial();  
        TipoMaterial ObterTipoMaterialPorId(int id);  
        void RegistrarTipoMaterial(TipoMaterial tipoMaterial); 
        void AtualizarTipoMaterial(TipoMaterial tipoMaterial);
        void ExcluirTipoMaterial(int id);
    }
}