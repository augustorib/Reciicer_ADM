using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> ListarCliente();  
        Cliente ObterClientePorId(int id);  
        void RegistrarCliente(Cliente cliente); 
        void AtualizarCliente(Cliente cliente);
        Cliente DetalharCliente(int id);
        void ExcluirCliente(int id);

    }
}