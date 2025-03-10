using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class RecolhimentoMaterialRepository : IRecolhimentoMaterialRepository
    {

        private readonly AppDbContext _context;

        public RecolhimentoMaterialRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<RecolhimentoMaterial> ListarRecolhimentoMaterial()
        {
            return _context.RecolhimentoMaterial.ToList();
        }

        public RecolhimentoMaterial ObterRecolhimentoMaterialPorId(int id)
        {
            return _context.RecolhimentoMaterial.Find(id);
        }

        public void RegistrarRecolhimentoMaterial(RecolhimentoMaterial recolhimentoMaterial)
        {
            var transaction = _context.Database.BeginTransaction();

            try
            {
                _context.RecolhimentoMaterial.Add(recolhimentoMaterial);
                _context.SaveChanges();

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }

        }

        public void ExcluirRecolhimentoMaterial(int id)
        {
            var recolhimentoMaterial = _context.RecolhimentoMaterial.Find(id);
            
            if(recolhimentoMaterial != null)
            {
                _context.RecolhimentoMaterial.Remove(recolhimentoMaterial);
                _context.SaveChanges();
            }
        }

    }

}