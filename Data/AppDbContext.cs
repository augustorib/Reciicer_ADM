using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reciicer.Models.Entities;

namespace Reciicer.Data
{
    public class AppDbContext : IdentityDbContext<UsuarioIdentity>
    {

        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente {Id = 1, Nome= "Jurandir", Email ="jurandir@gmail.com", Telefone ="(65) 4984-9849", CPF ="777.777.777-77", PontuacaoTotal = 15},
                new Cliente {Id = 2, Nome= "Judit", Email ="judit@gmail.com", Telefone ="(54) 4545-4544", CPF ="544.894.849-98"},
                new Cliente {Id = 3, Nome= "Astolfo", Email ="astolfo@gmail.com", Telefone ="(92) 98308-7102", CPF ="894.399.251-32"},
                new Cliente {Id = 4, Nome= "Padaria Manoel", Email ="manoel@padaria.com", Telefone ="(31) 98371-8402", CNPJ ="54.594.954/9549-89"}
               
            );

            modelBuilder.Entity<Premiacao>().HasData(
                new Premiacao {Id = 1, Nome= "Ingresso UCI", Descricao= "Ingresso para 1 sessão de cinema", Ativo = true, PontuacaoRequerida= 1000 },
                new Premiacao {Id = 2, Nome= "Desconto 10%", Descricao= "Desconto de 10% em compras até R$200,00 ", Ativo = false, PontuacaoRequerida= 100 },
                new Premiacao {Id = 3, Nome= "Boné", Descricao= "Boné personalizado ", Ativo = true, PontuacaoRequerida= 200 }
               
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
                new Coleta{Id = 1, DataOperacao = DateTime.Now, PontuacaoGanha = 10, ClienteId = 1, PontoColetaId=2 },
                new Coleta{Id = 2, DataOperacao = DateTime.Now, PontuacaoGanha = 5, ClienteId = 1, PontoColetaId =2 }
  
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

            var adminRoleId = "298f1256-ec97-4797-966c-d813afa14f70";
            var operadorRoleId = "8a62bbbf-8420-459c-94d3-9da153f3803f";
            var adminUserId = "8868b1f4-812f-4bbd-a438-1b25f7241f78";
            var operadorUserId = "02f34b97-229a-4764-ba00-2298903959c5";

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = operadorRoleId, Name = "Operador", NormalizedName = "OPERADOR" }
            );

            modelBuilder.Entity<UsuarioIdentity>().HasData(
                new UsuarioIdentity { Id = adminUserId, UserName = "admin", NormalizedUserName = "ADMIN", Email = "admin@gmail.com", NormalizedEmail ="ADMIN@GMAIL.COM",PasswordHash = "AQAAAAIAAYagAAAAELOGUtUv5slutFj/g2ySNtpAyK6JnEzlfSGIQVH2hL8onfOArNzzqS3hzh4KBbfBlg==", PontoColetaId=1 },
                new UsuarioIdentity { Id = operadorUserId, UserName = "operador", NormalizedUserName = "OPERADOR", Email = "operador@gmail.com", NormalizedEmail ="OPERADOR@GMAIL.COM", PasswordHash = "AQAAAAIAAYagAAAAEHQ7mga+DIAlOUen1rubIYWrGtJL/2ELlGuZQrZgvy/1u0aPPJa1UHG0VWqHJa06uA==", PontoColetaId = 2 }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = adminUserId, RoleId = adminRoleId },
                new IdentityUserRole<string> { UserId = operadorUserId, RoleId = operadorRoleId }
            );
            
            modelBuilder.Entity<ClientePremiacao>().HasData(
                new ClientePremiacao{Id = 1, DataOperacao = new DateTime(2024, 11, 21, 4, 23, 6, 153, DateTimeKind.Local), ClienteId = 3, PremiacaoId = 3}
            );

            modelBuilder.Entity<Recolhimento>().HasData(
                new Recolhimento{Id = 1, DataRecolhimento = new DateTime(2024, 11, 21, 4, 23, 6, 153, DateTimeKind.Local), CooperativaId = 1},   
                new Recolhimento{Id = 2, DataRecolhimento = new DateTime(2025, 02, 21, 6, 23, 6, 153, DateTimeKind.Local), CooperativaId = 1}
            );

            modelBuilder.Entity<Cooperativa>().HasData(
                new Cooperativa{Id = 1, Nome = "Cooperativa de Reciclagem", Email = "", CNPJ = "00.000.000/0000-00"}
            );

            modelBuilder.Entity<Estoque>().HasData(
                new Estoque{Id = 1, Codigo = "PR001", PontoColetaId = 1, Tipo = "Interno", PesoArmazenado = 0, QuantidadeArmazenada = 0 ,Capacidade = 10},
                new Estoque{Id = 2, Codigo = "PRN001", PontoColetaId = 2, Tipo = "Externo", PesoArmazenado = 0, QuantidadeArmazenada = 0 ,Capacidade = 5}            );

        }
        
        public DbSet<Cliente> Cliente {get; set;}
        public DbSet<Premiacao> Premiacao {get; set;}
        public DbSet<Material> Material {get; set;}
        public DbSet<TipoMaterial> TipoMaterial {get; set;}
        public DbSet<Coleta> Coleta {get; set;}
        public DbSet<Material_Coleta> Material_Coleta {get; set;}
        public DbSet<PontoColeta> PontoColeta {get; set;}
        public DbSet<Endereco> Endereco {get; set;}
        public DbSet<ClientePremiacao> ClientePremiacao {get; set;}
        public DbSet<Recolhimento> Recolhimento {get; set;}
        public DbSet<Cooperativa> Cooperativa {get; set;}
        public DbSet<RecolhimentoEstoqueMaterial> RecolhimentoEstoqueMaterial {get; set;}
        public DbSet<Estoque> Estoque {get; set;}
        public DbSet<EstoqueMaterial> EstoqueMaterial {get; set;}
        
    }
}