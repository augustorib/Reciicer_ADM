using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class RecolhimentoSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recolhimento>().HasData(
                new Recolhimento { Id = 8, DataRecolhimento = new DateTime(2025, 3, 25, 19, 4, 0, DateTimeKind.Local), CooperativaId = 2 },
                new Recolhimento { Id = 9, DataRecolhimento = new DateTime(2025, 3, 18, 19, 4, 0, DateTimeKind.Local), CooperativaId = 1 },
                new Recolhimento { Id = 13, DataRecolhimento = new DateTime(2025, 3, 5, 19, 42, 0, DateTimeKind.Local), CooperativaId = 2 },
                new Recolhimento { Id = 14, DataRecolhimento = new DateTime(2025, 3, 5, 1, 54, 0, DateTimeKind.Local), CooperativaId = 2 },
                new Recolhimento { Id = 15, DataRecolhimento = new DateTime(2025, 3, 7, 2, 18, 0, DateTimeKind.Local), CooperativaId = 1 }
            );
        }
    }
}