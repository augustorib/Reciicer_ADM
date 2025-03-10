using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.Cooperativa
{
    public class CooperativaService
    {
        private readonly ICooperativaRepository _cooperativaRepository;

        public CooperativaService(ICooperativaRepository cooperativaRepository)
        {
            _cooperativaRepository = cooperativaRepository;
        }

        public IEnumerable<Entities.Cooperativa> ListarCooperativa()
        {
            return _cooperativaRepository.ListarCooperativa();
        }

        public Entities.Cooperativa ObterCooperativaPorId(int id)
        {
            return _cooperativaRepository.ObterCooperativaPorId(id);
        }

        public void RegistrarCooperativa(Entities.Cooperativa cooperativa)
        {
            _cooperativaRepository.RegistrarCooperativa(cooperativa);
        }
        public void AtualizarCooperativa(Entities.Cooperativa cooperativa)
        {
            _cooperativaRepository.AtualizarCooperativa(cooperativa);
        }
        
        public void ExcluirCooperativa(int id)
        {
            _cooperativaRepository.ExcluirCooperativa(id);
        }
    }
}