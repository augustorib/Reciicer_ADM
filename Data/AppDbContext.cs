using Microsoft.EntityFrameworkCore;
using Reciicer.Models.Entities;

namespace Reciicer.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nivel>().HasData(
                new Nivel {Id = 1, Descricao= "Iniciante", PontuacaoNecessario = 0, PontosPerdaFrequencia = 0},
                new Nivel {Id = 2, Descricao= "Básico", PontuacaoNecessario = 10, PontosPerdaFrequencia =2},
                new Nivel {Id = 3, Descricao= "Intermediário", PontuacaoNecessario = 50, PontosPerdaFrequencia =10},
                new Nivel {Id = 4, Descricao= "Avançado", PontuacaoNecessario = 200, PontosPerdaFrequencia = 20}
            );
           
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente {Id = 1, Nome= "Jurandir", Email ="jurandir@gmail.com", Telefone ="(85)98792-0782", CPF ="48906785062", NivelId = 3},
                new Cliente {Id = 2, Nome= "Judit", Email ="judit@gmail.com", Telefone ="(69)99727-2310", CPF ="48517494067", NivelId = 2},
                new Cliente {Id = 3, Nome= "Astolfo", Email ="astolfo@gmail.com", Telefone ="(92)98308-7102", CPF ="71134549504", NivelId = 4}
               
            );
        }
        
        public DbSet<Cliente> Cliente {get; set;}
        public DbSet<Nivel> Nivel { get; set; }
        
    }
}