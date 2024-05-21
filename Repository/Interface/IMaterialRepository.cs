using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IMaterialRepository
    {
        IEnumerable<Material> ListarMaterial();  
        Material ObterMaterialPorId(int id);  
        void RegistrarMaterial(Material material); 
        void AtualizarMaterial(Material material);
        void ExcluirMaterial(int id);
    }
}