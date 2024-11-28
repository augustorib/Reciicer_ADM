using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Models.Entities;
using Reciicer.Models.HomeViewModels;
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

        public IEnumerable<Cliente> ListarClientesComPontuacaoTotal()
        {
            CalcularPontuacaoTotalClientes();

            var clientes = _context.Cliente.ToList();

            return clientes;
        }

        public Cliente ObterClientePorId(int id)
        {
            return _context.Cliente.Find(id);
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
        public IEnumerable<Cliente> ListarClienteNivelPremiacao()
        {
            return _context.Cliente.ToList();
        }

        public void CalcularPontuacaoTotalClientes()
        {
            var query = @"SELECT 
                            CL.ID AS ClienteId, 
                            --Caso o cliente não tenha prêmios trás a sua pontuação total
                            COALESCE(
                                SUM(C.PontuacaoGanha) - (SELECT SUM(PR.PontuacaoRequerida) FROM Premiacao PR WHERE PR.ClienteId = CL.Id),
                                
                                SUM(C.PontuacaoGanha) 
                            )
                                AS PontuacaoTotal
                        FROM 
                            Coleta C
                            JOIN Cliente CL ON CL.Id = C.ClienteId
                        GROUP BY
                            CL.Id";

            var clientes =_context.Database.SqlQueryRaw<ClientePontuacaoTotal>(query).ToList(); 

            foreach(var cliente in clientes)
            {
                var clienteBd = _context.Cliente.Find(cliente.ClienteId);

                if(clienteBd != null)
                {
                    clienteBd.PontuacaoTotal = cliente.PontuacaoTotal;
                    
                    _context.Cliente.Update(clienteBd);
                    _context.SaveChanges();
                }
            }
        }
    }
}