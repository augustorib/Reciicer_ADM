using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Reciicer.Data.Configurations
{
    public class RecolhimentoConfiguration : IEntityTypeConfiguration<Recolhimento>
    {
        public void Configure(EntityTypeBuilder<Recolhimento> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.DataRecolhimento).IsRequired();
        }
    }
}