using Reciicer.Repository;
using Reciicer.Repository.Interface;


namespace Reciicer.Service.Cliente
{
    public class ClienteService 
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }


         public IEnumerable<Models.Entities.Cliente> CalcularPontuacaoTotalCliente()
         {

            var clientesComPontuacaoENivelAtualizados =_clienteRepository.ListarClienteComPontuacaoTotal();
            
            AtualizarClientesNivel();

            return clientesComPontuacaoENivelAtualizados;
         }

         public void AtualizarClientesNivel()
         {
            _clienteRepository.AtualizarClientesNivelProc();
         }
    }
}