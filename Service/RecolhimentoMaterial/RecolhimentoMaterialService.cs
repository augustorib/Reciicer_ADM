using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.RecolhimentoMaterial
{
    public class RecolhimentoMaterialService
    {
        private readonly IRecolhimentoMaterialRepository _recolhimentoMaterialRepository;

        public RecolhimentoMaterialService(IRecolhimentoMaterialRepository recolhimentoMaterialRepository)
        {
            _recolhimentoMaterialRepository = recolhimentoMaterialRepository;
        }

        public IEnumerable<Entities.RecolhimentoMaterial> ListarRecolhimentoMaterial()
        {
            return _recolhimentoMaterialRepository.ListarRecolhimentoMaterial();
        }

        public Entities.RecolhimentoMaterial ObterRecolhimentoMaterialPorId(int id)
        {
            return _recolhimentoMaterialRepository.ObterRecolhimentoMaterialPorId(id);
        }

        public void RegistrarRecolhimentoMaterial(Entities.RecolhimentoMaterial recolhimentoMaterial)
        {
            _recolhimentoMaterialRepository.RegistrarRecolhimentoMaterial(recolhimentoMaterial);
        }

        public void ExcluirRecolhimentoMaterial(int id)
        {
            _recolhimentoMaterialRepository.ExcluirRecolhimentoMaterial(id);
        }
        
    }
}