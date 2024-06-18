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

        public IEnumerable<Models.Entities.Cliente> ObterClientesOrdenadoPorPontuação()
        {
            var  clientesTop3 = _clienteRepository.ListarCliente()
                                                  .OrderByDescending(c => c.PontuacaoTotal)
                                                  .Take(3)
                                                  .ToList();
            return clientesTop3;
        }

         public void AtualizarClientesNivel()
         {
            _clienteRepository.AtualizarClientesNivelProc();
         }
 
        
         public int ObterTotalClientes()
         {
             return _clienteRepository.ListarCliente().Count();
         }

         public IEnumerable<Models.Entities.Cliente> ObterClientesPremiacao()
         {
             return _clienteRepository.ListarClienteNivelPremiacao();
         }
    }
}