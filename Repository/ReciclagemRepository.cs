using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models;
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
            return _context.Reciclagem.Include(r => r.Cliente)
                                      .OrderByDescending(r => r.Id)
                                      .ToList();
        }

        public Reciclagem ObterReciclagemPorId(int id)
        {
            return _context.Reciclagem.Include(c => c.Cliente).FirstOrDefault(r => r.Id == id);
        }

        public void AtualizarReciclagem(Reciclagem reciclagem)
        {
            var reciclagemDB = _context.Reciclagem.Find(reciclagem.Id);

            if(reciclagemDB != null)
            {
                reciclagemDB.DataOperacao = reciclagem.DataOperacao;

                _context.Reciclagem.Update(reciclagemDB);
                _context.SaveChanges();
            }

        }


        public ReciclagemReadViewModel DetalharReciclagem(int id)
        {   
            var reciclagem = _context.Reciclagem.Find(id);

            var materiaisReciclagem = _context.Material_Reciclagem.Include( m => m.Material)
                                                                  .Include(m => m.TipoMaterial).Where(mr => mr.ReciclagemId == reciclagem.Id)
                                                                  .ToList();
    
            var reciclagemReadViewModel = new ReciclagemReadViewModel{
                Cliente = _context.Cliente.Find(reciclagem.ClienteId),
                Reciclagem = reciclagem,
                Materiais_Reciclagem = materiaisReciclagem

            };

            return reciclagemReadViewModel;
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

       public void ExcluirReciclagem(int id)
        {
           var reciclagemRemover = _context.Reciclagem.Find(id);

           if(reciclagemRemover != null)
           {
                _context.Reciclagem.Remove(reciclagemRemover);
                _context.SaveChanges();
           }
        }

        public Reciclagem ObterClienteUltimaReciclagem(int clienteId)
        {
            return _context.Reciclagem.Where(r => r.ClienteId == clienteId)
                                      .Include(r => r.Cliente)
                                      .OrderByDescending(r => r.Id)
                                      .FirstOrDefault();
        }

        public void CalcularPontuacaoReciclagem(int reciclagemId)
        {
            _context.Database.ExecuteSqlRaw("Exec UpdateReciclagemPontuacaoGanha @ReciclagemId", 
                                            new SqlParameter("@ReciclagemId", reciclagemId));
        }
    }
}