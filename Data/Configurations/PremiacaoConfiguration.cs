

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reciicer.Models.Entities;

namespace Reciicer.Data.Configurations
{
    public class PremiacaoConfiguration : IEntityTypeConfiguration<Premiacao>
    {
        public void Configure(EntityTypeBuilder<Premiacao> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Descricao).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Ativo).IsRequired();
            builder.Property(p => p.PontuacaoRequerida).IsRequired();
            
            builder.HasIndex(p => p.Nome).IsUnique();
            
        }
    }
}