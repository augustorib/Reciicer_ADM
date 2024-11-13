using Reciicer.Repository.Interface;
using  Model = Reciicer.Models.Entities;



namespace Reciicer.Service.Cliente
{
    public class ClienteService 
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void RegistrarCliente(Model.Cliente cliente)
        {
            _clienteRepository.RegistrarCliente(cliente);
        }

        public Model.Cliente ObterClientePorId(int id)
        {
           return _clienteRepository.ObterClientePorId(id);
        }

        public void AtualizarCliente(Model.Cliente cliente)
        {
            _clienteRepository.AtualizarCliente(cliente);
        }

        public void ExcluirCliente(int id)
        {
            _clienteRepository.ExcluirCliente(id);
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