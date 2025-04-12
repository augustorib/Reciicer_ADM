using Reciicer.Models.Entities;
using Reciicer.Models.HomeViewModels;

namespace Reciicer.Repository.Interface
{
    public interface ITipoMaterialRepository
    {
        IEnumerable<TipoMaterial> ListarTipoMaterial();  
        TipoMaterial ObterTipoMaterialPorId(int id);  
        void RegistrarTipoMaterial(TipoMaterial tipoMaterial); 
        void AtualizarTipoMaterial(TipoMaterial tipoMaterial);
        void ExcluirTipoMaterial(int id);
        public IEnumerable<TipoMaterialQuantidadeChart> ObterNomeQuantidadeTipoMaterialGrafico(int anoDashboard);
        public IEnumerable<TipoMaterialQuantidadeChart> ObterNomeQuantidadeTipoMaterialGrafico(int anoDashboard, int pontoColetaId);
    }
}