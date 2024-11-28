using Microsoft.AspNetCore.Identity;
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
                new Cliente {Id = 1, Nome= "Jurandir", Email ="jurandir@gmail.com", Telefone ="(85)98792-0782", CPF ="48906785062", PontuacaoTotal = 15},
                new Cliente {Id = 2, Nome= "Judit", Email ="judit@gmail.com", Telefone ="(69)99727-2310", CPF ="48517494067"},
                new Cliente {Id = 3, Nome= "Astolfo", Email ="astolfo@gmail.com", Telefone ="(92)98308-7102", CPF ="71134549504"},
                new Cliente {Id = 4, Nome= "Padaria Manoel", Email ="manoel@padaria.com", Telefone ="(31)98371-8402", CNPJ ="55434549711"}
               
            );

            modelBuilder.Entity<Premiacao>().HasData(
                new Premiacao {Id = 1, Nome= "Ingresso UCI", Descricao= "Ingresso para 1 sessão de cinema", Ativo = true, PontuacaoRequerida= 1000 },
                new Premiacao {Id = 2, Nome= "Desconto 10%", Descricao= "Desconto de 10% em compras até R$200,00 ", Ativo = false, PontuacaoRequerida= 100 },
                new Premiacao {Id = 3, Nome= "Boné", Descricao= "Boné personalizado ", Ativo = true, PontuacaoRequerida= 200, ClienteId =3 }
               
            );

            modelBuilder.Entity<Material>().HasData(
                new Material{Id = 1, Nome = "Papelão", Descricao ="Papelão", TempoDegradacao= 162000, PontuacaoPeso = 20, PontuacaoUnidade=2, TipoMaterialId =2},
                new Material{Id = 2, Nome = "Papel Presente", Descricao ="Papel de presente", TempoDegradacao= 150, PontuacaoPeso = 10, PontuacaoUnidade=5, TipoMaterialId=2},
                new Material{Id = 3, Nome = "PET", Descricao ="Garrafa PET - Polietileno Tereftalato", TempoDegradacao= 18000, PontuacaoPeso = 15, PontuacaoUnidade=3, TipoMaterialId=1},
                new Material{Id = 4, Nome = "Copo", Descricao ="Copo de Vidro", TempoDegradacao= 1000000, PontuacaoPeso = 25, PontuacaoUnidade= 10, TipoMaterialId=3}     
            );

            modelBuilder.Entity<TipoMaterial>().HasData(
                new TipoMaterial{Id = 1, Nome = "Plástico", Descricao = "Plástico",  Ativo = true },
                new TipoMaterial{Id = 2, Nome = "Papel", Descricao = "Papel",  Ativo = true },
                new TipoMaterial{Id = 3, Nome = "Vidro", Descricao = "Vidro",  Ativo = true },
                new TipoMaterial{Id = 4, Nome = "Metal", Descricao = "Metal",  Ativo = true }
  
            );

            modelBuilder.Entity<Coleta>().HasData(
                new Coleta{Id = 1, DataOperacao = DateTime.Now, PontuacaoGanha = 10, ClienteId = 1 },
                new Coleta{Id = 2, DataOperacao = DateTime.Now, PontuacaoGanha = 5, ClienteId = 1 }
  
            );

            modelBuilder.Entity<Material_Coleta>().HasData(
                new Material_Coleta{Id = 1, Peso = 5, Quantidade = 0, ColetaId = 1, MaterialId = 3}
                
            );

            modelBuilder.Entity<PontoColeta>().HasData(
                new PontoColeta{Id = 1, Nome = "Parmê", EnderecoId = 1},
                new PontoColeta{Id = 2, Nome = "Supermercado Guanabara", EnderecoId = 2}
                  
            );

            modelBuilder.Entity<Endereco>().HasData(
                new Endereco{Id = 1, Rua = "Rua 1", Bairro = "Bairro 1", Numero = 1, Cidade = "Cidade 1", Estado = "Estado 1", Cep = "60000-000"},
                new Endereco{Id = 2, Rua = "Rua 2", Bairro = "Bairro 2", Numero = 2, Cidade = "Cidade 2", Estado = "Estado 2", Cep = "60000-001"}       
            );

            var adminRoleId = Guid.NewGuid().ToString();
            var operadorRoleId = Guid.NewGuid().ToString();
            var adminUserId = Guid.NewGuid().ToString();
            var operadorUserId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = operadorRoleId, Name = "Operador", NormalizedName = "OPERADOR" }
            );

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser { Id = adminUserId, UserName = "admin", NormalizedUserName = "ADMIN", Email = "admin@gmail.com", NormalizedEmail ="ADMIN@GMAIL.COM",PasswordHash = "AQAAAAIAAYagAAAAELOGUtUv5slutFj/g2ySNtpAyK6JnEzlfSGIQVH2hL8onfOArNzzqS3hzh4KBbfBlg==" },
                new IdentityUser { Id = operadorUserId, UserName = "operador", NormalizedUserName = "OPERADOR", Email = "operador@gmail.com", NormalizedEmail ="OPERADOR@GMAIL.COM", PasswordHash = "AQAAAAIAAYagAAAAEHQ7mga+DIAlOUen1rubIYWrGtJL/2ELlGuZQrZgvy/1u0aPPJa1UHG0VWqHJa06uA==" }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = adminUserId, RoleId = adminRoleId },
                new IdentityUserRole<string> { UserId = operadorUserId, RoleId = operadorRoleId }
            );
        }
        
        public DbSet<Cliente> Cliente {get; set;}
        public DbSet<Premiacao> Premiacao {get; set;}
        public DbSet<Material> Material {get; set;}
        public DbSet<TipoMaterial> TipoMaterial {get; set;}
        public DbSet<Coleta> Coleta {get; set;}
        public DbSet<Material_Coleta> Material_Coleta {get; set;}
        public DbSet<PontoColeta> PontoColeta {get; set;}
        public DbSet<Endereco> Endereco {get; set;}

        
    }
}