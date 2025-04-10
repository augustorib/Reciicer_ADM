using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class CooperativaSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cooperativa>().HasData(
                new Cooperativa { Id = 1, Nome = "Cooperativa de Reciclagem", Email = "coop@gmail.com", CNPJ = "00.000.000" },
                new Cooperativa { Id = 2, Nome = "Comlurb", Email = "comlurb@gmail.com", CNPJ = "48489484848" }
            );
        }
    }
}