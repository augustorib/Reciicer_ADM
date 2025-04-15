using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class ClientePremiacaoSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientePremiacao>().HasData(
                new ClientePremiacao { Id = 1, DataOperacao = new DateTime(2024, 11, 21, 4, 23, 6, 153, DateTimeKind.Local), ClienteId = 3, PremiacaoId = 3 },
                new ClientePremiacao { Id = 2, DataOperacao = new DateTime(2024, 12, 3, 20, 21, 1, 913, DateTimeKind.Local), ClienteId = 2, PremiacaoId = 3 },
                new ClientePremiacao { Id = 3, DataOperacao = new DateTime(2025, 1, 21, 2, 15, 38, 995, DateTimeKind.Local), ClienteId = 7, PremiacaoId = 3 },
                new ClientePremiacao { Id = 1004, DataOperacao = new DateTime(2025, 2, 4, 17, 27, 18, 12, DateTimeKind.Local), ClienteId = 1010, PremiacaoId = 3 },
                new ClientePremiacao { Id = 1005, DataOperacao = new DateTime(2025, 2, 19, 23, 37, 4, 812, DateTimeKind.Local), ClienteId = 8, PremiacaoId = 3 }
            );
        }
    }
}