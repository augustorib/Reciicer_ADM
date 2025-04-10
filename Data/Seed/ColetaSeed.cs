using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class ColetaSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coleta>().HasData(
                new Coleta { Id = 1, DataOperacao = new DateTime(2025, 3, 24, 16, 50, 54, 765), PontuacaoGanha = 10, ClienteId = 1, PontoColetaId = 2},
                new Coleta { Id = 3, DataOperacao = new DateTime(2024, 9, 4, 20, 8, 0), PontuacaoGanha = 54, ClienteId = 2, PontoColetaId = 1},
                new Coleta { Id = 4, DataOperacao = new DateTime(2024, 10, 17, 20, 9, 0), PontuacaoGanha = 20, ClienteId = 3, PontoColetaId = 1},
                new Coleta { Id = 5, DataOperacao = new DateTime(2024, 11, 17, 20, 10, 0), PontuacaoGanha = 6, ClienteId = 1, PontoColetaId = 1},
                new Coleta { Id = 6, DataOperacao = new DateTime(2024, 11, 22, 20, 11, 0), PontuacaoGanha = 150, ClienteId = 1, PontoColetaId = 1},
                new Coleta { Id = 7, DataOperacao = new DateTime(2024, 12, 3, 20, 20, 0), PontuacaoGanha = 115, ClienteId = 2, PontoColetaId = 1},
                new Coleta { Id = 8, DataOperacao = new DateTime(2024, 12, 2, 20, 20, 0), PontuacaoGanha = 200, ClienteId = 2, PontoColetaId = 1},
                new Coleta { Id = 9, DataOperacao = new DateTime(2024, 11, 14, 20, 43, 0), PontuacaoGanha = 30, ClienteId = 6, PontoColetaId = 2},
                new Coleta { Id = 10, DataOperacao = new DateTime(2024, 10, 8, 20, 44, 0), PontuacaoGanha = 260, ClienteId = 7, PontoColetaId = 2},
                new Coleta { Id = 11, DataOperacao = new DateTime(2024, 12, 18, 0, 18, 0), PontuacaoGanha = 1000, ClienteId = 5, PontoColetaId = 1},
                new Coleta { Id = 12, DataOperacao = new DateTime(2024, 12, 11, 0, 21, 0), PontuacaoGanha = 250, ClienteId = 3, PontoColetaId = 1},
                new Coleta { Id = 13, DataOperacao = new DateTime(2025, 1, 9, 2, 16, 0), PontuacaoGanha = 75, ClienteId = 7, PontoColetaId = 1},
                new Coleta { Id = 14, DataOperacao = new DateTime(2025, 1, 22, 14, 54, 0), PontuacaoGanha = 0, ClienteId = 9, PontoColetaId = 1},
                new Coleta { Id = 1014, DataOperacao = new DateTime(2025, 2, 4, 17, 25, 0), PontuacaoGanha = 120, ClienteId = 1010, PontoColetaId = 2},
                new Coleta { Id = 1015, DataOperacao = new DateTime(2025, 2, 4, 17, 26, 0), PontuacaoGanha = 200, ClienteId = 1010, PontoColetaId = 2},
                new Coleta { Id = 1016, DataOperacao = new DateTime(2025, 2, 3, 17, 51, 0), PontuacaoGanha = 6, ClienteId = 1010, PontoColetaId = 1},
                new Coleta { Id = 1017, DataOperacao = new DateTime(2023, 3, 12, 18, 41, 0), PontuacaoGanha = 75, ClienteId = 1, PontoColetaId = 1},
                new Coleta { Id = 1018, DataOperacao = new DateTime(2023, 7, 7, 22, 2, 0), PontuacaoGanha = 100, ClienteId = 7, PontoColetaId = 1},
                new Coleta { Id = 1019, DataOperacao = new DateTime(2025, 2, 19, 23, 36, 0), PontuacaoGanha = 200, ClienteId = 8, PontoColetaId = 1},
                new Coleta { Id = 2085, DataOperacao = new DateTime(2025, 3, 4, 1, 57, 0), PontuacaoGanha = 120, ClienteId = 1, PontoColetaId = 1},
                new Coleta { Id = 2090, DataOperacao = new DateTime(2025, 3, 13, 3, 40, 0), PontuacaoGanha = 0, ClienteId = 7, PontoColetaId = 1},
                new Coleta { Id = 2091, DataOperacao = new DateTime(2025, 3, 13, 3, 41, 0), PontuacaoGanha = 0, ClienteId = 2, PontoColetaId = 1},
                new Coleta { Id = 2092, DataOperacao = new DateTime(2025, 3, 5, 3, 42, 0), PontuacaoGanha = 0, ClienteId = 2, PontoColetaId = 1},
                new Coleta { Id = 3090, DataOperacao = new DateTime(2025, 3, 20, 19, 2, 0), PontuacaoGanha = 4, ClienteId = 1, PontoColetaId = 1},
                new Coleta { Id = 3091, DataOperacao = new DateTime(2025, 2, 26, 19, 40, 0), PontuacaoGanha = 90, ClienteId = 2, PontoColetaId = 1},
                new Coleta { Id = 3092, DataOperacao = new DateTime(2025, 3, 18, 19, 41, 0), PontuacaoGanha = 120, ClienteId = 1, PontoColetaId = 1},
                new Coleta { Id = 4103, DataOperacao = new DateTime(2025, 3, 4, 17, 10, 0), PontuacaoGanha = 20, ClienteId = 2, PontoColetaId = 1},
                new Coleta { Id = 4105, DataOperacao = new DateTime(2025, 3, 6, 19, 51, 0), PontuacaoGanha = 0, ClienteId = 1, PontoColetaId = 1}
            );
        }
    }
}