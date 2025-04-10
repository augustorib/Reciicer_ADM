using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class PontoColetaSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PontoColeta>().HasData(
                new PontoColeta { Id = 1, Nome = "Parmê", EnderecoId = 1 },
                new PontoColeta { Id = 2, Nome = "Supermercado Guanabara", EnderecoId = 2 }
            );
        }
    }
}