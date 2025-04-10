using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Reciicer.Data.Configurations
{
    public class ClientePremiacaoConfiguration : IEntityTypeConfiguration<ClientePremiacao>
    {
        public void Configure(EntityTypeBuilder<ClientePremiacao> builder)
        {
            builder.HasKey(cp => cp.Id);
            builder.Property(cp => cp.DataOperacao).IsRequired();
            builder.Property(cp => cp.ClienteId).IsRequired();
            builder.Property(cp => cp.PremiacaoId).IsRequired();
        }
    }
}