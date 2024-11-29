using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class ClientePremiacaoRepository : IClientePremiacaoRepository
    {
        private readonly AppDbContext _context; 

        public ClientePremiacaoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ClientePremiacao> ListarClientePremiacao()
        {
            return _context.ClientePremiacao.ToList();
        }
        public void RegistrarClientePremiacao(ClientePremiacao clientePremiacao)
        {
            var transaction = _context.Database.BeginTransaction();

            try
            {
                _context.ClientePremiacao.Add(clientePremiacao);
                _context.SaveChanges();

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }

        public ClientePremiacao ObterClientePremiacaoPorId(int id)
        {
           return _context.ClientePremiacao.Find(id);
        }

        public void ExcluirClientePremiacao(int id)
        {
            var clientePremiacao = _context.ClientePremiacao.Find(id);
            
            if(clientePremiacao != null)
            {
                _context.ClientePremiacao.Remove(clientePremiacao);
                _context.SaveChanges();
            }
        }
    }
}