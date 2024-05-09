using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface INivelRepository
    {
        IEnumerable<Nivel> ListarNivel();  
        Nivel ObterNivelPorId(int id);  
        void RegistrarNivel(Nivel nivel); 
        void AtualizarNivel(Nivel nivel);
        void ExcluirNivel(int id);
    }
}