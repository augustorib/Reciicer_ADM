
using Reciicer.Repository.Interface;

namespace Reciicer.Service.TipoMaterial
{
    public class TipoMaterialService
    {
        private readonly ITipoMaterialRepository _tipoMaterialRepsitory;

        public TipoMaterialService(ITipoMaterialRepository tipoMaterialRepository)
        {
            _tipoMaterialRepsitory = tipoMaterialRepository;
        }


        public IEnumerable<Models.Entities.TipoMaterial> PopularSelect()
        {
            return _tipoMaterialRepsitory.ListarTipoMaterial();
        } 
        public IEnumerable<Models.Entities.TipoMaterial> PopularSelectFiltrandoPorMaterialId(int materialId)
        {
            return _tipoMaterialRepsitory.ListarTipoMaterialPorMaterialId(materialId);
        } 
        public Models.Entities.TipoMaterial ObterTipoMaterialPorId(int tipoMaterialId)
        {
            return _tipoMaterialRepsitory.ObterTipoMaterialPorId(tipoMaterialId);
        } 
    }
}