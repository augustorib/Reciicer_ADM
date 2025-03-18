using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class Material_ColetaRepository : IMaterial_ColetaRepository
    {

        private readonly AppDbContext _context;

        public Material_ColetaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Material_Coleta> ListarMaterialColeta()
        {
            return _context.Material_Coleta.ToList();
        }
        
        public IEnumerable<Material_Coleta> ListarMaterialColetaMaterial()
        {
            return _context.Material_Coleta.Include(mc => mc.Material).ToList();
        }
        
        public IEnumerable<Material_Coleta> ListarMaterialColetaPorColetaId(int ColetaId)
        {
            return _context.Material_Coleta.Where(mc => mc.ColetaId == ColetaId)
                                               .Include(mc => mc.Material)
                                               .ThenInclude(m => m.TipoMaterial)
                                               .ToList();
        }

        public Material_Coleta ObterMaterialColetaPorId(int id)
        {
            return _context.Material_Coleta.Include(mc => mc.Coleta).FirstOrDefault(mc => mc.Id == id);
        }

        public void RegistrarMaterialColeta(Material_Coleta materialColeta)
        {
             var transaction = _context.Database.BeginTransaction();

            try
            {
                _context.Material_Coleta.Add(materialColeta);
                _context.SaveChanges();

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }

        public void ExcluirMaterialColeta(int id)
        {
            var materialColeta = _context.Material_Coleta.Find(id);
            
            if(materialColeta != null)
            {
                _context.Material_Coleta.Remove(materialColeta);
                _context.SaveChanges();
            }
        }


    }
}