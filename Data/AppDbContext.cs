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

        }
        
        public DbSet<Cliente> Cliente {get; set;}

        
        
    }
}