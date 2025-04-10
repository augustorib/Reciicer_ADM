using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Reciicer.Data.Configurations
{
    public class MaterialConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Nome).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Descricao).IsRequired().HasMaxLength(500);
            builder.Property(m => m.TempoDegradacao).IsRequired();
            builder.Property(m => m.PontuacaoPeso).IsRequired();
            builder.Property(m => m.PontuacaoUnidade).IsRequired();
            
            builder.HasIndex(m => m.Nome).IsUnique();
            
        }
    }

}