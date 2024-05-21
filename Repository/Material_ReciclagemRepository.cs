
using Microsoft.EntityFrameworkCore;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;
using Reciicer.Data;

namespace Reciicer.Repository
{
    public class Material_ReciclagemRepository : IMaterial_ReciclagemRepository
    {
        private readonly AppDbContext _context;

        public Material_ReciclagemRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Material_Reciclagem> ListarMaterialReciclagem()
        {
            throw new NotImplementedException();
        }

        public Material_Reciclagem ObterMaterialReciclagemPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void RegistrarMaterialReciclagem(Material_Reciclagem materialReciclagem)
        {
            var transaction = _context.Database.BeginTransaction();

            try
            {
                _context.Material_Reciclagem.Add(materialReciclagem);
                _context.SaveChanges();

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }
    }
}