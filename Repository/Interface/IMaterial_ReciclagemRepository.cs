

using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IMaterial_ReciclagemRepository
    {
        IEnumerable<Material_Reciclagem> ListarMaterialReciclagem();  
        IEnumerable<Material_Reciclagem> ListarMaterialReciclagemPorReciclagemId(int reciclagemId);  
        Material_Reciclagem ObterMaterialReciclagemPorId(int id);  
        void RegistrarMaterialReciclagem(Material_Reciclagem materialReciclagem); 
        void ExcluirMaterialReciclagem(int id);
    }
}