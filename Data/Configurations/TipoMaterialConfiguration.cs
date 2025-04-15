using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Reciicer.Data.Configurations
{
    public class TipoMaterialConfiguration : IEntityTypeConfiguration<TipoMaterial>
    {
        public void Configure(EntityTypeBuilder<TipoMaterial> builder)
        {
            builder.HasKey(tm => tm.Id);
            builder.Property(tm => tm.Nome).IsRequired().HasMaxLength(100);
            builder.Property(tm => tm.Descricao).IsRequired().HasMaxLength(500);
            builder.Property(tm => tm.Ativo).IsRequired();
        
            builder.Property(tm => tm.Ativo).HasDefaultValue(true);
            
            builder.HasIndex(tm => tm.Nome).IsUnique();
        }
    }

}