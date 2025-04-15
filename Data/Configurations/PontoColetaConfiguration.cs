using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Reciicer.Data.Configurations
{
    public class PontoColetaConfiguration : IEntityTypeConfiguration<PontoColeta>
    {
        public void Configure(EntityTypeBuilder<PontoColeta> builder)
        {
            builder.HasKey(pc => pc.Id);
            builder.Property(pc => pc.Nome).IsRequired().HasMaxLength(100);

            builder.HasIndex(pc => pc.Nome).IsUnique();
        }
    }
}