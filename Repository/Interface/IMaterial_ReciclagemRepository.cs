

using Reciicer.Models.Entities;

namespace Reciicer.Repository.Interface
{
    public interface IMaterial_ReciclagemRepository
    {
        IEnumerable<Material_Reciclagem> ListarMaterialReciclagem();  
        Material_Reciclagem ObterMaterialReciclagemPorId(int id);  
        void RegistrarMaterialReciclagem(Material_Reciclagem materialReciclagem); 
    }
}