using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class RecolhimentoEstoqueMaterialSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecolhimentoEstoqueMaterial>().HasData(
                new RecolhimentoEstoqueMaterial { Id = 5, RecolhimentoId = 8, EstoqueMaterialId = 1165, Quantidade = 1, Peso = 0 },
                new RecolhimentoEstoqueMaterial { Id = 6, RecolhimentoId = 9, EstoqueMaterialId = 1165, Quantidade = 1, Peso = 0 },
                new RecolhimentoEstoqueMaterial { Id = 9, RecolhimentoId = 13, EstoqueMaterialId = 1169, Quantidade = 0, Peso = 1 },
                new RecolhimentoEstoqueMaterial { Id = 1002, RecolhimentoId = 14, EstoqueMaterialId = 1169, Quantidade = 0, Peso = 2 },
                new RecolhimentoEstoqueMaterial { Id = 1003, RecolhimentoId = 15, EstoqueMaterialId = 2163, Quantidade = 2, Peso = 0 }
            );
        }
    }
}