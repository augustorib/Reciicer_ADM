using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class MaterialRepository : IMaterialRepository
    {

        private readonly AppDbContext _context;

        public MaterialRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Material> ListarMaterial()
        {
            return _context.Material.ToList();
        }

        public void AtualizarMaterial(Material material)
        {
            throw new NotImplementedException();
        }

        public void ExcluirMaterial(int id)
        {
            throw new NotImplementedException();
        }
        public Material ObterMaterialPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void RegistrarMaterial(Material material)
        {
            throw new NotImplementedException();
        }
    }
}