using Microsoft.Data.SqlClient;
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

        public IEnumerable<Cliente> ListarCliente()
        {
            var clientes = _context.Cliente.Include(n => n.Nivel).ToList();

            return clientes;
        }     

        public IEnumerable<Cliente> ListarClienteComPontuacaoTotal()
        {

            _context.Database.ExecuteSqlRaw("EXEC UpdateClientePontuacaoTotal");

            var clientes = _context.Cliente.Include(n => n.Nivel).ToList();

            return clientes;
        }

        public Cliente ObterClientePorId(int id)
        {
            return _context.Cliente.Find(id);
        }

        public void RegistrarCliente(Cliente model)
        {
           
            var cliente = new Cliente(model.Nome, model.Email, model.Telefone, model.CPF, 1);
 
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
        }

        public Cliente DetalharCliente(int id)
        {
           
            var clienteBD = _context.Cliente
                                    .Include(n => n.Nivel)
                                    .FirstOrDefault(c => c.Id == id);
                
            if(clienteBD is not null)
            {
                return clienteBD;
            }

            return null;

        }

        public void AtualizarCliente(Cliente cliente)
        {
            var clienteBD = _context.Cliente.Find(cliente.Id);


            if (clienteBD != null)
            {
                clienteBD.Nome = cliente.Nome;
                clienteBD.Telefone = cliente.Telefone;
                clienteBD.CPF = cliente.CPF;
                clienteBD.Email = cliente.Email;


                _context.Cliente.Update(clienteBD);
                _context.SaveChanges();

            }

        }

        public void AtualizarClientesNivelProc()
        {
            var clientes = _context.Cliente.ToList();
            
            foreach(var cliente in clientes)
            {
                _context.Database.ExecuteSqlRaw("EXEC UpdateClienteNivel @PontuacaoTotalCliente, @ClienteID", 
                                                new SqlParameter("@PontuacaoTotalCliente", cliente.PontuacaoTotal),
                                                new SqlParameter("@ClienteID", cliente.Id));

            }
        }

        public void ExcluirCliente(int id)
        {
           var clienteRemover = _context.Cliente.Find(id);

           if(clienteRemover != null)
           {
                _context.Cliente.Remove(clienteRemover);
                _context.SaveChanges();
           }

        }

    }
}