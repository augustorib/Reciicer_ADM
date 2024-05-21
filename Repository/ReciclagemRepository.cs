using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class ReciclagemRepository : IReciclagemRepository
    {
        
        private readonly AppDbContext _context;

        public ReciclagemRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Reciclagem> ListarReciclagem()
        {
            return _context.Reciclagem.Include(c => c.Cliente).ToList();
        }

        public void AtualizarReciclagem(Reciclagem reciclagem)
        {
            throw new NotImplementedException();
        }

        public void ExcluirReciclagem(int id)
        {
            throw new NotImplementedException();
        }

        public Reciclagem ObterReciclagemPorId(int id)
        {
            return _context.Reciclagem.Find(id);
        }

        public void RegistrarReciclagem(Reciclagem reciclagem)
        {   
             var transaction = _context.Database.BeginTransaction();

             try
             {
                _context.Reciclagem.Add(reciclagem);
                _context.SaveChanges();

                transaction.Commit();
             }
             catch(Exception e)
             {
                transaction.Rollback();
             }
        }


    }
}