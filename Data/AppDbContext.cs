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

            modelBuilder.Entity<Reciclagem>().HasData(
                new Reciclagem {Id = 1, DataOperacao = DateTime.Now, PontuacaoGanha = 10, ClienteId = 1 },
                new Reciclagem {Id = 2, DataOperacao = DateTime.Now, PontuacaoGanha = 5, ClienteId = 1 }
        
            );

            modelBuilder.Entity<Material>().HasData(
                new Material {Id = 1, Nome = "Plástico", Descricao = "Plástico",  Ativo = true  },
                new Material {Id = 2, Nome = "Papel", Descricao = "Papel",  Ativo = true  },
                new Material {Id = 3, Nome = "Vidro", Descricao = "Vidro",  Ativo = true  },
                new Material {Id = 4, Nome = "Metal", Descricao = "Metal",  Ativo = true  }
      
            );


            modelBuilder.Entity<Material_Reciclagem>().HasData(
                new Material_Reciclagem {Id = 1, MaterialId = 2, Peso = 5, Quantidade = 0, ReciclagemId = 1}
            );

            modelBuilder.Entity<TipoMaterial>().HasData(
                new TipoMaterial{Id = 1, Nome = "Papelão", Descricao ="Papelão", TempoDegradacao= 162000, MaterialId = 2},
                new TipoMaterial{Id = 2, Nome = "Papel Presente", Descricao ="Papel de presente", TempoDegradacao= 150, MaterialId = 2},
                new TipoMaterial{Id = 3, Nome = "PET", Descricao ="Garrafa PET - Polietileno Tereftalato", TempoDegradacao= 18000, MaterialId = 1},
                new TipoMaterial{Id = 4, Nome = "Copo", Descricao ="Copo de Vidro", TempoDegradacao= 1000000, MaterialId = 3}
            );

            modelBuilder.Entity<PontuacaoMaterial>().HasData(
                new PontuacaoMaterial{Id = 1, PontuacaoPeso = 20, PontuacaoUnidade = 2, TipoMaterialId = 2 },
                new PontuacaoMaterial{Id = 2, PontuacaoPeso = 100, PontuacaoUnidade = 10, TipoMaterialId = 4},
                new PontuacaoMaterial{Id = 3, PontuacaoPeso = 50, PontuacaoUnidade = 5, TipoMaterialId = 1}

                

            );

        }
        
        public DbSet<Cliente> Cliente {get; set;}
        public DbSet<Nivel> Nivel { get; set; }
        public DbSet<Reciclagem> Reciclagem {get; set;}
        public DbSet<Material> Material {get; set;}
        public DbSet<TipoMaterial> TipoMaterial {get; set;}
        public DbSet<PontuacaoMaterial> PontuacaoMaterial {get; set;}
        public DbSet<Material_Reciclagem> Material_Reciclagem {get; set;}
        
        
    }
}