using Reciicer.Models;
using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IReciclagemRepository
    {  
        IEnumerable<Reciclagem> ListarReciclagem();  
        Reciclagem ObterReciclagemPorId(int id);  
        void RegistrarReciclagem(Reciclagem reciclagem); 
        ReciclagemReadViewModel DetalharReciclagem(int id); 
        void AtualizarReciclagem(Reciclagem reciclagem);
        void ExcluirReciclagem(int id);
        Reciclagem ObterClienteUltimaReciclagem(int ClienteId);
        void CalcularPontuacaoReciclagem(int reciclagemId);
    }
}