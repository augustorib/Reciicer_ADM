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

        public void RegistrarRecolhimentoMaterial(IList<Entities.RecolhimentoMaterial> recolhimentoMateriais, int recolhimentoId)
        {
            foreach (var recolhimentoMaterial in recolhimentoMateriais)
            {
                if(recolhimentoMaterial.QuantidadeTotal == 0 && recolhimentoMaterial.PesoTotal==0) 
                    continue;

                 recolhimentoMaterial.RecolhimentoId = recolhimentoId;
                _recolhimentoMaterialRepository.RegistrarRecolhimentoMaterial(recolhimentoMaterial);
                
            }
        }

        public void AtualizarRecolhimentoMaterial(IList<Entities.RecolhimentoMaterial> recolhimentoMateriais)
        {
            foreach (var recolhimentoMaterial in recolhimentoMateriais)
            {
                if(recolhimentoMaterial.QuantidadeTotal == 0 && recolhimentoMaterial.PesoTotal==0) 
                    continue;

                _recolhimentoMaterialRepository.AtualizarRecolhimentoMaterial(recolhimentoMaterial);
                
            }
        }
 
 
        public void ExcluirRecolhimentoMaterial(int id)
        {
            _recolhimentoMaterialRepository.ExcluirRecolhimentoMaterial(id);
        }
        
    }
}