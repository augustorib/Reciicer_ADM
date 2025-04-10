using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reciicer.Models.Entities;

namespace Reciicer.Data.Configurations
{
    public class MaterialColetaConfiguration : IEntityTypeConfiguration<Material_Coleta>
    {
        public void Configure(EntityTypeBuilder<Material_Coleta> builder)
        {
            builder.HasKey(mc => mc.Id);
            builder.Property(mc => mc.Peso).IsRequired();
            builder.Property(mc => mc.Quantidade).IsRequired();
        }
    }
}