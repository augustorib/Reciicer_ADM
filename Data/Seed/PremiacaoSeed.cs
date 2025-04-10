using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace Reciicer.Data.Seed
{
    public static class PremiacaoSeed
    {
        
        public static void Seed(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Premiacao>().HasData(
                new Premiacao {Id = 1, Nome= "Ingresso UCI", Descricao= "Ingresso para 1 sessão de cinema", Ativo = true, PontuacaoRequerida= 1000 },
                new Premiacao {Id = 2, Nome= "Desconto 10%", Descricao= "Desconto de 10% em compras até R$200,00 ", Ativo = false, PontuacaoRequerida= 100 },
                new Premiacao {Id = 3, Nome= "Boné", Descricao= "Boné personalizado ", Ativo = true, PontuacaoRequerida= 200 } 
            );

        }
    }
}