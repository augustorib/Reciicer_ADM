using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.EstoqueMaterial
{
    public class EstoqueMaterialService
    {
        private readonly IEstoqueMaterialRepository _estoqueMaterialRepository;

        public EstoqueMaterialService(IEstoqueMaterialRepository estoqueMaterialRepository)
        {
            _estoqueMaterialRepository = estoqueMaterialRepository;
        }

        public IEnumerable<Entities.EstoqueMaterial> ListarEstoqueMaterial()
        {
            return _estoqueMaterialRepository.ListarEstoqueMaterial();
        }

        public Entities.EstoqueMaterial ObterEstoqueMaterialPorId(int id)
        {
            return _estoqueMaterialRepository.ObterEstoqueMaterialPorId(id);
        }

        public void RegistrarEstoqueMaterial(Entities.EstoqueMaterial EstoqueMaterial)
        {
            _estoqueMaterialRepository.RegistrarEstoqueMaterial(EstoqueMaterial);
        }

        public void AtualizarEstoqueMaterial(Entities.EstoqueMaterial EstoqueMaterial)
        {
            _estoqueMaterialRepository.AtualizarEstoqueMaterial(EstoqueMaterial);
        }

        public void ExcluirEstoqueMaterial(int id)
        {
            _estoqueMaterialRepository.ExcluirEstoqueMaterial(id);
        }
    }
}