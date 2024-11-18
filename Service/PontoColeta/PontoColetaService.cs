using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.PontoColeta
{
    public class PontoColetaService
    {
        private readonly IPontoColetaRepository _pontoColetaRepository;

        public PontoColetaService(IPontoColetaRepository pontoColetaRepository)
        {
            _pontoColetaRepository = pontoColetaRepository;
        }

        public IEnumerable<Entities.PontoColeta> ListarPontoColeta()
        {
            return _pontoColetaRepository.ListarPontoColeta();
        }
        public Entities.PontoColeta ObterPontoColetaPorId(int id)
        {
            return _pontoColetaRepository.ObterPontoColetaPorId(id);
        }

        public void RegistrarPontoColeta(Entities.PontoColeta pontoColeta)
        {
            _pontoColetaRepository.RegistrarPontoColeta(pontoColeta);
        }
        public void AtualizarPontoColeta(Entities.PontoColeta pontoColeta)
        {
            _pontoColetaRepository.AtualizarPontoColeta(pontoColeta);
        }
        public void ExcluirPontoColeta(int id)
        {
            _pontoColetaRepository.ExcluirPontoColeta(id);
        }

        
 
    }
}