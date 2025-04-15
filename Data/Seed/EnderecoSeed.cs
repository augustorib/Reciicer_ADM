using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class EnderecoSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endereco>().HasData(
                new Endereco { Id = 1, Rua = "Rua 1", Numero = 1, Bairro = "Bairro 1", Cidade = "Cidade 1", Estado = "Estado 1", Cep = "60000-000" },
                new Endereco { Id = 2, Rua = "Rua 2", Numero = 2, Bairro = "Bairro 2", Cidade = "Cidade 2", Estado = "Estado 2", Cep = "60000-001" }
            );
        }
    }
}