using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> ListarCliente();  
        IEnumerable<Cliente> ListarClienteComPontuacaoTotal();  
        IEnumerable<Cliente> ListarClienteNivelPremiacao();  
        Cliente ObterClientePorId(int id);  
        void RegistrarCliente(Cliente cliente); 
        void AtualizarCliente(Cliente cliente);
        void AtualizarClientesNivelProc();
        void ExcluirCliente(int id);

    }
}