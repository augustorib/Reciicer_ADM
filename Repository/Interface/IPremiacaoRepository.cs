using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IPremiacaoRepository
    {
        
        IEnumerable<Premiacao> ListarPremiacao();  
        Premiacao ObterPremiacaoPorId(int id);  
        void RegistrarPremiacao(Premiacao premiacao); 
        void AtualizarPremiacao(Premiacao premiacao);
        void ExcluirPremiacao(int id);
    }
}