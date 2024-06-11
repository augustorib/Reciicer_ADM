using Reciicer.Models.Entities;
using Reciicer.Models.HomeViewModels;
using Reciicer.Repository.Interface;

namespace Reciicer.Service.Material
{
    public class MaterialService
    {
        private readonly IMaterialRepository _materialRepository;

        public MaterialService(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }


        public IEnumerable<Models.Entities.Material> PopularSelect()
        {
            return _materialRepository.ListarMaterial();
        }

        public IEnumerable<string> ListarNomesMaterial()
        {
            return PopularSelect().Select(m => m.Nome).ToList();
        }

        public IEnumerable<MaterialQuantidadeChart> ObterMaterialQuantidadeChart()
        {
            return _materialRepository.ObterNomeeQuantidadeMateriaisGrafico();
        }

    }
}