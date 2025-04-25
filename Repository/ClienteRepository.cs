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
            var clientes = _context.Cliente.ToList();

            return clientes;
        }     

        public Cliente ObterClientePorId(int id)
        {
            return _context.Cliente.Find(id)!;
        }

        public void RegistrarCliente(Cliente model)
        {
           
            _context.Cliente.Add(model);
            _context.SaveChanges();
        }

        public Cliente DetalharCliente(int id)
        {
           
            var clienteBD = _context.Cliente.FirstOrDefault(c => c.Id == id);
                
            if(clienteBD is not null)
            {
                return clienteBD;
            }

            return new Cliente();

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
                clienteBD.CNPJ = cliente.CNPJ;


                _context.Cliente.Update(clienteBD);
                _context.SaveChanges();

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