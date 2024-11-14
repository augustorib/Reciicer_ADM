using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.Material
{
    public class MaterialService
    {
        private readonly IMaterialRepository _materialRepository;

        public MaterialService(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }

        public IEnumerable<Entities.Material> ListarMaterial()
        {
            return _materialRepository.ListarMaterial();
        }

        public Entities.Material ObterMaterialPorId(int id)
        {
            return _materialRepository.ObterMaterialPorId(id);
        }

        public void RegistrarMaterial(Entities.Material material)
        {
            _materialRepository.RegistrarMaterial(material);
        }
        public void AtualizarMaterial(Entities.Material material)
        {
            _materialRepository.AtualizarMaterial(material);
        }

        public void ExcluirMaterial(int id)
        {
            _materialRepository.ExcluirMaterial(id);
        }

        public IEnumerable<Entities.Material> PopularSelectFiltrandoPorTipoMaterialId(int tipoMaterialId)
        {
            //return _materialRepsitory.ListarTipoMaterialPorMaterialId(tipoMaterialId);
            return _materialRepository.ListarMaterial()
                                      .Where(m => m.TipoMaterialId == tipoMaterialId);
        } 

    }
}