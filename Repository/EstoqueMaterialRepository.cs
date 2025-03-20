
using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class EstoqueMaterialRepository : IEstoqueMaterialRepository
    {

        private readonly AppDbContext _context;

        public EstoqueMaterialRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<EstoqueMaterial> ListarEstoqueMaterial()
        {
            return _context.EstoqueMaterial.Include(em => em.Material).ToList();
        }
        
        public EstoqueMaterial ObterEstoqueMaterialPorId(int id)
        {
            return _context.EstoqueMaterial.Include(em => em.Material).FirstOrDefault(em => em.Id == id);
        }

        public IEnumerable<EstoqueMaterial> ObterEstoqueMaterialPorEstoqueId(int estoqueId)
        {
            return _context.EstoqueMaterial.Include(em => em.Material).Where(em => em.EstoqueId == estoqueId).ToList();
        }

        public void RegistrarEstoqueMaterial(EstoqueMaterial estoqueMaterial)
        {
            _context.EstoqueMaterial.Add(estoqueMaterial);
            _context.SaveChanges();
        }

        public void AtualizarEstoqueMaterial(EstoqueMaterial estoqueMaterial)
        {
            var estoqueMaterialDb = _context.EstoqueMaterial.Find(estoqueMaterial.Id);

            if (estoqueMaterialDb != null)
            {
                estoqueMaterialDb.Quantidade = estoqueMaterial.Quantidade;
                estoqueMaterialDb.Peso = estoqueMaterial.Peso;
                estoqueMaterialDb.MaterialId = estoqueMaterial.MaterialId;
                estoqueMaterialDb.EstoqueId = estoqueMaterial.EstoqueId;

                _context.EstoqueMaterial.Update(estoqueMaterialDb);
                _context.SaveChanges();
            }
        }

        public void ExcluirEstoqueMaterial(int id)
        {
            var estoqueMaterialBd = _context.EstoqueMaterial.Find(id);

            if (estoqueMaterialBd != null)
            {
                _context.EstoqueMaterial.Remove(estoqueMaterialBd);
                _context.SaveChanges();
            }
        }  

        public IEnumerable<EstoqueMaterial> ObterEstoqueMaterialPorMaterialEstoque(int estoqueId, int materialId)
        {
            return _context.EstoqueMaterial.Where(em => em.EstoqueId == estoqueId && em.MaterialId == materialId).ToList();
        }
    }
}