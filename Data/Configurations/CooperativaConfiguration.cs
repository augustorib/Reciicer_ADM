using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Reciicer.Data.Configurations
{
    public class CooperativaConfiguration : IEntityTypeConfiguration<Cooperativa>
    {
        public void Configure(EntityTypeBuilder<Cooperativa> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            builder.Property(c => c.CNPJ).IsRequired().HasMaxLength(18);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
        
            builder.HasIndex(c => c.CNPJ).IsUnique();
            builder.HasIndex(c => c.Email).IsUnique();

        }
    }
}