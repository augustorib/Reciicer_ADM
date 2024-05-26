

using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IPontuacaoMaterialRepository
    {
        IEnumerable<PontuacaoMaterial> ListarPontuacaoMaterial();  
        PontuacaoMaterial ObterPontuacaoMaterialPorId(int id);  
        void RegistrarPontuacaoMaterial(PontuacaoMaterial pontuacaoMaterial); 
        void AtualizarPontuacaoMaterial(PontuacaoMaterial pontuacaoMaterial);
        void ExcluirPontuacaoMaterial(int id);
    }
}