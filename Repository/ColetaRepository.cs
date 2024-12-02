using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class ColetaRepository : IColetaRepository
    {
           
        private readonly AppDbContext _context;

        public ColetaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Coleta> ListarColeta()
        {
            return _context.Coleta.Include(r => r.Cliente)
                                      .OrderByDescending(r => r.Id)
                                      .ToList();
        }

        public Coleta ObterColetaPorId(int id)
        {
            return _context.Coleta.Include(c => c.Cliente).FirstOrDefault(r => r.Id == id);
        }

        public void AtualizarColeta(Coleta coleta)
        {
            var coletaBd = _context.Coleta.Find(coleta.Id);

            if(coletaBd != null)
            {
                coletaBd.DataOperacao = coleta.DataOperacao;

                _context.Coleta.Update(coletaBd);
                _context.SaveChanges();
            }

        }

        public void RegistrarColeta(Coleta coleta)
        {   
             var transaction = _context.Database.BeginTransaction();

             try
             {
                _context.Coleta.Add(coleta);
                _context.SaveChanges();

                transaction.Commit();
             }
             catch(Exception e)
             {
                transaction.Rollback();
             }
        }

       public void ExcluirColeta(int id)
        {
           var rcoletaRemover = _context.Coleta.Find(id);

           if(rcoletaRemover != null)
           {
                _context.Coleta.Remove(rcoletaRemover);
                _context.SaveChanges();
           }
        }

       public void RecolherColeta(int id)
        {
           var recolherColeta = _context.Coleta.Find(id);

           if(recolherColeta != null)
           {
                recolherColeta.Ativo = true;

                _context.Coleta.Update(recolherColeta);
                _context.SaveChanges();
           }
        }

        public Coleta ObterClienteUltimaColeta(int clienteId)
        {
            return _context.Coleta.Where(r => r.ClienteId == clienteId)
                                      .Include(r => r.Cliente)
                                      .OrderByDescending(r => r.Id)
                                      .FirstOrDefault();
        }

        public void CalcularPontuacaoColeta(int coletaId)
        {
            _context.Database.ExecuteSqlRaw("Exec UpdateColetaPontuacaoGanha @ColetaId", 
                                            new SqlParameter("@ColetaId", coletaId));
        }
    }
}