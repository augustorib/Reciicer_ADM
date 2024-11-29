using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IClientePremiacaoRepository
    {
        IEnumerable<ClientePremiacao> ListarClientePremiacao();    
        ClientePremiacao ObterClientePremiacaoPorId(int id);  
        void RegistrarClientePremiacao(ClientePremiacao clientePremiacao); 
        void ExcluirClientePremiacao(int id);
    }
}