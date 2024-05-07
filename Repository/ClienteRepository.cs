using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public void ExcluirCliente(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ListarCliente()
        {
            var clientes = _context.Cliente.Include(n => n.Nivel).ToList();

            return clientes;
        }

        public Cliente ObterClientePorId(int id)
        {
            throw new NotImplementedException();
        }

        public void RegistrarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}