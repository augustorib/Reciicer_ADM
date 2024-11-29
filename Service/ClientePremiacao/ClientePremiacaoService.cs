using Reciicer.Repository.Interface;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.ClientePremiacao
{
    public class ClientePremiacaoService
    {
        private readonly IClientePremiacaoRepository _clientePremiacaoRepository;

        public ClientePremiacaoService(IClientePremiacaoRepository clientePremiacaoRepository)
        {
            _clientePremiacaoRepository = clientePremiacaoRepository;
        }
 
        public IEnumerable<Entities.ClientePremiacao> ListarClientePremiacao()
        {
            return _clientePremiacaoRepository.ListarClientePremiacao();
        }  

        public Entities.ClientePremiacao ObterClientePremiacaoPorId(int id)
        {
            return _clientePremiacaoRepository.ObterClientePremiacaoPorId(id);
        }

        public void RegistrarClientePremiacao(Entities.ClientePremiacao clientePremiacao)
        {
            _clientePremiacaoRepository.RegistrarClientePremiacao(clientePremiacao);
        } 
        public void ExcluirClientePremiacao(int id)
        {
            _clientePremiacaoRepository.ExcluirClientePremiacao(id);
        }
    }
}