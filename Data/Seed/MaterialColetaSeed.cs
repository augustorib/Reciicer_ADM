using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class MaterialColetaSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material_Coleta>().HasData(
                new Material_Coleta { Id = 1, Peso = 5, Quantidade = 0, ColetaId = 1, MaterialId = 3 },
                new Material_Coleta { Id = 2, Peso = 0, Quantidade = 2, ColetaId = 3, MaterialId = 1 },
                new Material_Coleta { Id = 3, Peso = 2, Quantidade = 0, ColetaId = 3, MaterialId = 4 },
                new Material_Coleta { Id = 4, Peso = 0, Quantidade = 2, ColetaId = 4, MaterialId = 4 },
                new Material_Coleta { Id = 5, Peso = 0, Quantidade = 2, ColetaId = 5, MaterialId = 3 },
                new Material_Coleta { Id = 6, Peso = 10, Quantidade = 0, ColetaId = 6, MaterialId = 3 },
                new Material_Coleta { Id = 7, Peso = 10, Quantidade = 0, ColetaId = 7, MaterialId = 5 },
                new Material_Coleta { Id = 8, Peso = 0, Quantidade = 5, ColetaId = 7, MaterialId = 3 },
                new Material_Coleta { Id = 9, Peso = 10, Quantidade = 0, ColetaId = 8, MaterialId = 1 },
                new Material_Coleta { Id = 10, Peso = 0, Quantidade = 3, ColetaId = 9, MaterialId = 4 },
                new Material_Coleta { Id = 11, Peso = 0, Quantidade = 20, ColetaId = 10, MaterialId = 3 },
                new Material_Coleta { Id = 12, Peso = 10, Quantidade = 0, ColetaId = 10, MaterialId = 1 },
                new Material_Coleta { Id = 13, Peso = 50, Quantidade = 0, ColetaId = 11, MaterialId = 1 },
                new Material_Coleta { Id = 14, Peso = 10, Quantidade = 0, ColetaId = 12, MaterialId = 4 },
                new Material_Coleta { Id = 15, Peso = 5, Quantidade = 0, ColetaId = 13, MaterialId = 3 },
                new Material_Coleta { Id = 16, Peso = 20, Quantidade = 0, ColetaId = 14, MaterialId = 1 },
                new Material_Coleta { Id = 1016, Peso = 10, Quantidade = 0, ColetaId = 1014, MaterialId = 2 },
                new Material_Coleta { Id = 1017, Peso = 0, Quantidade = 2, ColetaId = 1014, MaterialId = 4 },
                new Material_Coleta { Id = 1018, Peso = 10, Quantidade = 0, ColetaId = 1015, MaterialId = 1 },
                new Material_Coleta { Id = 1019, Peso = 0, Quantidade = 2, ColetaId = 1016, MaterialId = 3 },
                new Material_Coleta { Id = 1020, Peso = 5, Quantidade = 0, ColetaId = 1017, MaterialId = 3 },
                new Material_Coleta { Id = 1021, Peso = 0, Quantidade = 10, ColetaId = 1018, MaterialId = 4 },
                new Material_Coleta { Id = 1022, Peso = 20, Quantidade = 0, ColetaId = 1019, MaterialId = 2 },
                new Material_Coleta { Id = 2114, Peso = 0, Quantidade = 12, ColetaId = 2085, MaterialId = 4 },
                new Material_Coleta { Id = 3119, Peso = 0, Quantidade = 2, ColetaId = 3090, MaterialId = 5 },
                new Material_Coleta { Id = 3120, Peso = 6, Quantidade = 0, ColetaId = 3091, MaterialId = 3 },
                new Material_Coleta { Id = 3121, Peso = 6, Quantidade = 0, ColetaId = 3092, MaterialId = 1 },
                new Material_Coleta { Id = 4133, Peso = 0, Quantidade = 2, ColetaId = 4103, MaterialId = 4 }
            );
        }
    }
}