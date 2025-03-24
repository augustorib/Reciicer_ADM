using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class RecolhimentoEstoqueMaterialRepository : IRecolhimentoEstoqueMaterialRepository
    {
        private readonly AppDbContext _context;

        public RecolhimentoEstoqueMaterialRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<RecolhimentoEstoqueMaterial> ListarRecolhimentoEstoqueMaterial()
        {
            return _context.RecolhimentoEstoqueMaterial.ToList();
        }

        public RecolhimentoEstoqueMaterial ObterRecolhimentoEstoqueMaterialPorId(int id)
        {
            return _context.RecolhimentoEstoqueMaterial.Find(id);
        }

        public void RegistrarRecolhimentoEstoqueMaterial(RecolhimentoEstoqueMaterial recolhimentoEstoqueMaterial)
        {
            var transaction = _context.Database.BeginTransaction();

            try
            {
                _context.RecolhimentoEstoqueMaterial.Add(recolhimentoEstoqueMaterial);
                _context.SaveChanges();

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }

        public void AtualizarRecolhimentoEstoqueMaterial(RecolhimentoEstoqueMaterial recolhimentoEstoqueMaterial)
        {
            var recolhimentoEstoqueMaterialBd = ObterRecolhimentoEstoqueMaterialPorId(recolhimentoEstoqueMaterial.Id);

            if (recolhimentoEstoqueMaterialBd != null)
            {
                recolhimentoEstoqueMaterialBd.Quantidade = recolhimentoEstoqueMaterial.Quantidade;
                recolhimentoEstoqueMaterialBd.Peso = recolhimentoEstoqueMaterial.Peso;

                _context.RecolhimentoEstoqueMaterial.Update(recolhimentoEstoqueMaterialBd);
                _context.SaveChanges();
            }
        }

        public void ExcluirRecolhimentoEstoqueMaterial(int id)
        {
            var recolhimentoEstoqueMaterial = _context.RecolhimentoEstoqueMaterial.Find(id);
            
            if(recolhimentoEstoqueMaterial != null)
            {
                _context.RecolhimentoEstoqueMaterial.Remove(recolhimentoEstoqueMaterial);
                _context.SaveChanges();
            }
        }

    }
}