

using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IPontuacaoMaterialRepository
    {
        IEnumerable<PontuacaoMaterial> ListarPontuacaoMaterial();  
        PontuacaoMaterial ObterPontuacaoMaterialPorId(int id);  
        void RegistrarPontuacaoMaterial(PontuacaoMaterial PontuacaoMaterial); 
        void AtualizarPontuacaoMaterial(PontuacaoMaterial PontuacaoMaterial);
        void ExcluirPontuacaoMaterial(int id);
    }
}