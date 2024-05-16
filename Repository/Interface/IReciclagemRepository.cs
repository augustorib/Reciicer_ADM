using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IReciclagemRepository
    {  
        IEnumerable<Reciclagem> ListarReciclagem();  
        Reciclagem ObterReciclagemPorId(int id);  
        void RegistrarReciclagem(Reciclagem reciclagem); 
        void AtualizarReciclagem(Reciclagem reciclagem);
        void ExcluirReciclagem(int id);
    }
}