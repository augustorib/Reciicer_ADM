using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
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
            return _context.Reciclagem.Include(c => c.Cliente).ToList();
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

            var materiaisReciclagem = _context.Material_Reciclagem.Include( m => m.Material).Where(mr => mr.ReciclagemId == reciclagem.Id).ToList();
            //var materiaisId = materiaisReciclagem.Select( m => m.MaterialId).ToList();

            var reciclagemReadViewModel = new ReciclagemReadViewModel{
                Cliente = _context.Cliente.Find(reciclagem.ClienteId),
                Reciclagem = reciclagem,
                //Materiais = _context.Material.Where(m => materiaisId.Contains(m.Id)),
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
    }
}