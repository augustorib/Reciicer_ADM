using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class EstoqueSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estoque>().HasData(
                new Estoque { Id = 1, Codigo = "PR001", Tipo = "Interno", PontoColetaId = 1, Capacidade = 20, PesoArmazenado = 4, QuantidadeArmazenada = 16 },
                new Estoque { Id = 2, Codigo = "PRN001", Tipo = "Externo", PontoColetaId = 2, Capacidade = 5, PesoArmazenado = 0, QuantidadeArmazenada = 0 },
                new Estoque { Id = 1007, Codigo = "PN002", Tipo = "Normal", PontoColetaId = 1, Capacidade = 10, PesoArmazenado = 3, QuantidadeArmazenada = 6 },
                new Estoque { Id = 1008, Codigo = "PN003", Tipo = "Normal", PontoColetaId = 1, Capacidade = 10, PesoArmazenado = 2, QuantidadeArmazenada = 0 }

            );
        }
    }
}