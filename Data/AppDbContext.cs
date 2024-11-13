using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Reciicer.Models.Entities;

namespace Reciicer.Data
{
    public class AppDbContext : IdentityDbContext
    {

        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente {Id = 1, Nome= "Jurandir", Email ="jurandir@gmail.com", Telefone ="(85)98792-0782", CPF ="48906785062"},
                new Cliente {Id = 2, Nome= "Judit", Email ="judit@gmail.com", Telefone ="(69)99727-2310", CPF ="48517494067"},
                new Cliente {Id = 3, Nome= "Astolfo", Email ="astolfo@gmail.com", Telefone ="(92)98308-7102", CPF ="71134549504"},
                new Cliente {Id = 4, Nome= "Padaria Manoel", Email ="manoel@padaria.com", Telefone ="(31)98371-8402", CNPJ ="55434549711"}
               
            );

            modelBuilder.Entity<Premiacao>().HasData(
                new Premiacao {Id = 1, Nome= "Ingresso UCI", Descricao= "Ingresso para 1 sessão de cinema", Ativo = true, PontuacaoRequerida= 1000 },
                new Premiacao {Id = 2, Nome= "Desconto 10%", Descricao= "Desconto de 10% em compras até R$200,00 ", Ativo = false, PontuacaoRequerida= 100 },
                new Premiacao {Id = 3, Nome= "Boné", Descricao= "Boné personalizado ", Ativo = true, PontuacaoRequerida= 200, ClienteId =3 }
               
            );

 

        }
        
        public DbSet<Cliente> Cliente {get; set;}
        public DbSet<Premiacao> Premiacao {get; set;}

        
        
    }
}