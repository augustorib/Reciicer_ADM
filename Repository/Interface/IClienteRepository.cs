using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> ListarCliente();  
        IEnumerable<Cliente> ListarClienteComPontuacaoTotal();  
        Cliente ObterClientePorId(int id);  
        void RegistrarCliente(Cliente cliente); 
        void AtualizarCliente(Cliente cliente);
        void AtualizarClientesNivelProc();
        Cliente DetalharCliente(int id);
        void ExcluirCliente(int id);

    }
}