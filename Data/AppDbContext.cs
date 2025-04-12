using Reciicer.Data.Seed;
using Reciicer.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reciicer.Models.Entities;
using Reciicer.Service.Audit;


namespace Reciicer.Data
{
    public class AppDbContext : IdentityDbContext<UsuarioIdentity>
    {

        private readonly AuditService _auditService;

        public AppDbContext (DbContextOptions<AppDbContext> options, AuditService auditService) : base(options)
        {
            _auditService = auditService;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new ClientePremiacaoConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new PremiacaoConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialConfiguration());
            modelBuilder.ApplyConfiguration(new TipoMaterialConfiguration());
            modelBuilder.ApplyConfiguration(new ColetaConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialColetaConfiguration());
            modelBuilder.ApplyConfiguration(new PontoColetaConfiguration());
            modelBuilder.ApplyConfiguration(new RecolhimentoConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new CooperativaConfiguration());
            modelBuilder.ApplyConfiguration(new EstoqueConfiguration());

            ClienteSeed.Seed(modelBuilder);
            UsuarioIdentitySeed.Seed(modelBuilder);
            PremiacaoSeed.Seed(modelBuilder);
            MaterialSeed.Seed(modelBuilder);
            TipoMaterialSeed.Seed(modelBuilder);
            ColetaSeed.Seed(modelBuilder);
            MaterialColetaSeed.Seed(modelBuilder);
            PontoColetaSeed.Seed(modelBuilder);
            EnderecoSeed.Seed(modelBuilder);
            RecolhimentoSeed.Seed(modelBuilder);
            CooperativaSeed.Seed(modelBuilder);
            ClientePremiacaoSeed.Seed(modelBuilder);
            EstoqueSeed.Seed(modelBuilder);
            EstoqueMaterialSeed.Seed(modelBuilder);
            RecolhimentoEstoqueMaterialSeed.Seed(modelBuilder);

        }

        public override int SaveChanges()
        {
            _auditService.AplicarInformacoesAudit(ChangeTracker);
            _auditService.AuditInformacoesLog(ChangeTracker, AuditLog);
            
            return base.SaveChanges();
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
        public DbSet<AuditLog> AuditLog {get; set;}
        
    }
}