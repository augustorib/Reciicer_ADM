using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class EstoqueMaterialSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstoqueMaterial>().HasData(
                new EstoqueMaterial { Id = 158, Peso = 8, Quantidade = 0, EstoqueId = 1, MaterialId = 4 },
                new EstoqueMaterial { Id = 159, Peso = 2, Quantidade = 0, EstoqueId = 1007, MaterialId = 4 },
                new EstoqueMaterial { Id = 163, Peso = 6, Quantidade = 0, EstoqueId = 1, MaterialId = 5 },
                new EstoqueMaterial { Id = 164, Peso = 2, Quantidade = 0, EstoqueId = 1007, MaterialId = 5 },
                new EstoqueMaterial { Id = 171, Peso = 0, Quantidade = 0, EstoqueId = 1007, MaterialId = 3 },
                new EstoqueMaterial { Id = 172, Peso = 0, Quantidade = 0, EstoqueId = 1008, MaterialId = 3 },
                new EstoqueMaterial { Id = 1165, Peso = 0, Quantidade = 0, EstoqueId = 1, MaterialId = 5 },
                new EstoqueMaterial { Id = 1166, Peso = 0, Quantidade = 4, EstoqueId = 1, MaterialId = 3 },
                new EstoqueMaterial { Id = 1167, Peso = 0, Quantidade = 2, EstoqueId = 1007, MaterialId = 3 },
                new EstoqueMaterial { Id = 1168, Peso = 0, Quantidade = 1, EstoqueId = 1007, MaterialId = 1 },
                new EstoqueMaterial { Id = 1169, Peso = 0, Quantidade = 2, EstoqueId = 1008, MaterialId = 1 },
                new EstoqueMaterial { Id = 2163, Peso = 0, Quantidade = 0, EstoqueId = 2, MaterialId = 5 },
                new EstoqueMaterial { Id = 2164, Peso = 0, Quantidade = 0, EstoqueId = 1007, MaterialId = 1 },
                new EstoqueMaterial { Id = 2165, Peso = 0, Quantidade = 0, EstoqueId = 1007, MaterialId = 1 },
                new EstoqueMaterial { Id = 2166, Peso = 0, Quantidade = 0, EstoqueId = 1007, MaterialId = 1 },
                new EstoqueMaterial { Id = 2167, Peso = 0, Quantidade = 0, EstoqueId = 1007, MaterialId = 1 },
                new EstoqueMaterial { Id = 2168, Peso = 0, Quantidade = 0, EstoqueId = 1007, MaterialId = 3 },
                new EstoqueMaterial { Id = 2169, Peso = 0, Quantidade = 0, EstoqueId = 1007, MaterialId = 1 },
                new EstoqueMaterial { Id = 2170, Peso = 0, Quantidade = 0, EstoqueId = 1007, MaterialId = 3 },
                new EstoqueMaterial { Id = 2171, Peso = 0, Quantidade = 0, EstoqueId = 1007, MaterialId = 3 },
                new EstoqueMaterial { Id = 2172, Peso = 0, Quantidade = 0, EstoqueId = 1008, MaterialId = 3 },
                new EstoqueMaterial { Id = 2173, Peso = 0, Quantidade = 0, EstoqueId = 1007, MaterialId = 3 },
                new EstoqueMaterial { Id = 2174, Peso = 0, Quantidade = 0, EstoqueId = 1007, MaterialId = 1 },
                new EstoqueMaterial { Id = 2175, Peso = 0, Quantidade = 0, EstoqueId = 1007, MaterialId = 1 },
                new EstoqueMaterial { Id = 2176, Peso = 2, Quantidade = 0, EstoqueId = 1007, MaterialId = 4 },
                new EstoqueMaterial { Id = 2177, Peso = 0, Quantidade = 0, EstoqueId = 1, MaterialId = 1 },
                new EstoqueMaterial { Id = 2178, Peso = 0, Quantidade = 0, EstoqueId = 1, MaterialId = 1 },
                new EstoqueMaterial { Id = 2179, Peso = 0, Quantidade = 0, EstoqueId = 1, MaterialId = 1 },
                new EstoqueMaterial { Id = 2180, Peso = 2, Quantidade = 0, EstoqueId = 1, MaterialId = 4 },
                new EstoqueMaterial { Id = 2181, Peso = 0, Quantidade = 0, EstoqueId = 1007, MaterialId = 3 },
                new EstoqueMaterial { Id = 2182, Peso = 0, Quantidade = 0, EstoqueId = 1008, MaterialId = 3 }
            );
        }
    }
}