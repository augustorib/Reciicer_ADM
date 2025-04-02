using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface ICooperativaRepository
    {
        IEnumerable<Cooperativa> ListarCooperativa();   
        Cooperativa ObterCooperativaPorId(int id);  
        void RegistrarCooperativa(Cooperativa cooperativa); 
        void AtualizarCooperativa(Cooperativa cooperativa);
        void ExcluirCooperativa(int id);
    }
}