using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> ListarCliente();  
        void RegistrarCliente(Cliente cliente);
        Cliente ObterClientePorId(int id);
        void ExcluirCliente(int id);

    }
}