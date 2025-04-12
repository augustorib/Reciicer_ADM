using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Reciicer.Data.Configurations
{

    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Telefone).IsRequired().HasMaxLength(15);
            builder.Property(c => c.CPF).HasMaxLength(14);
            builder.Property(c => c.CNPJ).HasMaxLength(18);
            
            builder.Property(c => c.PontuacaoTotal).HasDefaultValue(0);
            builder.Property(c => c.CreatedBy).HasDefaultValue("8868b1f4-812f-4bbd-a438-1b25f7241f78");
            builder.Property(c => c.DataCadastro).HasDefaultValueSql("GETDATE()");

            builder.HasIndex(c => c.Email).IsUnique();
            builder.HasIndex(c => c.CPF).IsUnique();
            builder.HasIndex(c => c.CNPJ).IsUnique();

        }
    }
}