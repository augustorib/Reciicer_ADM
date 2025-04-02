using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.Recolhimento
{
    public class RecolhimentoService
    {
        private readonly IRecolhimentoRepository _recolhimentoRepository;

        public RecolhimentoService(IRecolhimentoRepository recolhimentoRepository)
        {
            _recolhimentoRepository = recolhimentoRepository;
        }

        public IEnumerable<Entities.Recolhimento> ListarRecolhimento()
        {
            return _recolhimentoRepository.ListarRecolhimento();
        }

        public Entities.Recolhimento ObterRecolhimentoPorId(int id)
        {
            return _recolhimentoRepository.ObterRecolhimentoPorId(id);
        }
        public Entities.Recolhimento ObterUltimoRecolhimento()
        {
            return _recolhimentoRepository.ListarRecolhimento().Last();
        }

        public void RegistrarRecolhimento(Entities.Recolhimento recolhimento)
        {
            _recolhimentoRepository.RegistrarRecolhimento(recolhimento);
        }

        public void AtualizarRecolhimento(Entities.Recolhimento recolhimento)
        {
            _recolhimentoRepository.AtualizarRecolhimento(recolhimento);
        }

        public void ExcluirRecolhimento(int id)
        {
            _recolhimentoRepository.ExcluirRecolhimento(id);
        }
        
    }
}