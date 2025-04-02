using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IRecolhimentoRepository
    {     
        IEnumerable<Recolhimento> ListarRecolhimento();   
        Recolhimento ObterRecolhimentoPorId(int id);  
        void RegistrarRecolhimento(Recolhimento recolhimento); 
        void AtualizarRecolhimento(Recolhimento recolhimento);
        void ExcluirRecolhimento(int id);
    }
}