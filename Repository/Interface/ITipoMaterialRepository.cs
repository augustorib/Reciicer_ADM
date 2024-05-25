using Reciicer.Models.Entities;
using Reciicer.Models.TipoMaterialViewModels;

namespace Reciicer.Repository.Interface
{
    public interface ITipoMaterialRepository
    {
        IEnumerable<TipoMaterial> ListarTipoMaterial();  
        TipoMaterial ObterTipoMaterialPorId(int id);  
        void RegistrarTipoMaterial(TipoMaterial tipoMaterial); 
        void AtualizarTipoMaterial(TipoMaterialCreateView tipoMaterialCreateView);
        void ExcluirTipoMaterial(int id);
    }
}