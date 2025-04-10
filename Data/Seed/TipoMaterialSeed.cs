using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class TipoMaterialSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoMaterial>().HasData(
                new TipoMaterial{Id = 1, Nome = "Plástico", Descricao = "Plástico",  Ativo = true },
                new TipoMaterial{Id = 2, Nome = "Papel", Descricao = "Papel",  Ativo = true },
                new TipoMaterial{Id = 3, Nome = "Vidro", Descricao = "Vidro",  Ativo = true },
                new TipoMaterial{Id = 4, Nome = "Metal", Descricao = "Metal",  Ativo = true }
  
            );
        }
    }
}