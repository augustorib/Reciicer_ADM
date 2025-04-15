using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class MaterialSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>().HasData(
                new Material{Id = 1, Nome = "Papelão", Descricao ="Papelão", TempoDegradacao= 162000, PontuacaoPeso = 20, PontuacaoUnidade=2, TipoMaterialId =2},
                new Material{Id = 2, Nome = "Papel Presente", Descricao ="Papel de presente", TempoDegradacao= 150, PontuacaoPeso = 10, PontuacaoUnidade=5, TipoMaterialId=2},
                new Material{Id = 3, Nome = "PET", Descricao ="Garrafa PET - Polietileno Tereftalato", TempoDegradacao= 18000, PontuacaoPeso = 15, PontuacaoUnidade=3, TipoMaterialId=1},
                new Material{Id = 4, Nome = "Copo", Descricao ="Copo de Vidro", TempoDegradacao= 1000000, PontuacaoPeso = 25, PontuacaoUnidade= 10, TipoMaterialId=3},     
                new Material{Id = 5, Nome = "Alumínio", Descricao ="Latinha", TempoDegradacao= 1000, PontuacaoPeso = 10, PontuacaoUnidade= 2, TipoMaterialId=4}     
            );

        }
    }
}