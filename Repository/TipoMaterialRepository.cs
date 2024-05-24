using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class TipoMaterialRepository : ITipoMaterialRepository
    {

        private readonly AppDbContext _context;

        public TipoMaterialRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<TipoMaterial> ListarTipoMaterial()
        {
            return _context.TipoMaterial.Include(t => t.Material).ToList();
        }

        public void RegistrarTipoMaterial(TipoMaterial tipoMaterial)
        {
            _context.TipoMaterial.Add(tipoMaterial);
            _context.SaveChanges();
        }

        public TipoMaterial ObterTipoMaterialPorId(int id)
        {
            return _context.TipoMaterial.Include(t => t.Material).FirstOrDefault(t => t.Id == id);
        }

        public void AtualizarTipoMaterial(TipoMaterial tipoMaterial)
        {
            throw new NotImplementedException();
        }

        public void ExcluirTipoMaterial(int id)
        {
            throw new NotImplementedException();
        }


    }
}