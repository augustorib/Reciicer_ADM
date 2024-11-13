using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.Premiacao
{
    public class PremiacaoService
    {
        private readonly IPremiacaoRepository _premiacaoRepository;

        public PremiacaoService(IPremiacaoRepository premiacaoRepository)
        {
            _premiacaoRepository = premiacaoRepository;
        }

        public IEnumerable<Entities.Premiacao> ListarPremiacao()
        {
            return _premiacaoRepository.ListarPremiacao();
        }  

        public Entities.Premiacao ObterPremiacaoPorId(int id)
        {
            return _premiacaoRepository.ObterPremiacaoPorId(id);
        }

        public void RegistrarPremiacao(Entities.Premiacao premiacao)
        {
            _premiacaoRepository.RegistrarPremiacao(premiacao);
        }
        public void AtualizarPremiacao(Entities.Premiacao premiacao)
        {
            _premiacaoRepository.AtualizarPremiacao(premiacao);
        }
        public void ExcluirPremiacao(int id)
        {
            _premiacaoRepository.ExcluirPremiacao(id);
        }
    }
}