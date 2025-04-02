using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.RecolhimentoEstoqueMaterial
{
    public class RecolhimentoEstoqueMaterialService
    {
        private readonly IRecolhimentoEstoqueMaterialRepository _recolhimentoEstoqueMaterialRepository;

        public RecolhimentoEstoqueMaterialService(IRecolhimentoEstoqueMaterialRepository recolhimentoEstoqueMaterialRepository)
        {
            _recolhimentoEstoqueMaterialRepository = recolhimentoEstoqueMaterialRepository;
        }

        public IEnumerable<Entities.RecolhimentoEstoqueMaterial> ListarRecolhimentoEstoqueMaterial()
        {
            return _recolhimentoEstoqueMaterialRepository.ListarRecolhimentoEstoqueMaterial();
        }

        public Entities.RecolhimentoEstoqueMaterial ObterRecolhimentoEstoqueMaterialPorId(int id)
        {
            return _recolhimentoEstoqueMaterialRepository.ObterRecolhimentoEstoqueMaterialPorId(id);
        }

        public void RegistrarRecolhimentoEstoqueMaterial(Entities.RecolhimentoEstoqueMaterial recolhimentoEstoqueMaterial)
        {
            _recolhimentoEstoqueMaterialRepository.RegistrarRecolhimentoEstoqueMaterial(recolhimentoEstoqueMaterial);
        }

        public void RegistrarRecolhimentoEstoqueMaterial(IList<Entities.RecolhimentoEstoqueMaterial> recolhimentoMateriais, int recolhimentoId)
        {
            foreach (var recolhimentoEstoqueMaterial in recolhimentoMateriais)
            {
                if(recolhimentoEstoqueMaterial.Quantidade == 0 && recolhimentoEstoqueMaterial.Peso ==0) 
                    continue;

                 recolhimentoEstoqueMaterial.RecolhimentoId = recolhimentoId;
                _recolhimentoEstoqueMaterialRepository.RegistrarRecolhimentoEstoqueMaterial(recolhimentoEstoqueMaterial);
                
            }
        }

        public void AtualizarRecolhimentoEstoqueMaterial(IList<Entities.RecolhimentoEstoqueMaterial> recolhimentoMateriais)
        {
            foreach (var recolhimentoEstoqueMaterial in recolhimentoMateriais)
            {
                if(recolhimentoEstoqueMaterial.Quantidade == 0 && recolhimentoEstoqueMaterial.Peso ==0) 
                    continue;

                _recolhimentoEstoqueMaterialRepository.AtualizarRecolhimentoEstoqueMaterial(recolhimentoEstoqueMaterial);
                
            }
        }
 
        public void ExcluirRecolhimentoEstoqueMaterial(int id)
        {
            _recolhimentoEstoqueMaterialRepository.ExcluirRecolhimentoEstoqueMaterial(id);
        }
        
    }
}