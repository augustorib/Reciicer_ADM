using Reciicer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class ClienteSeed
    {

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente {Id = 1, Nome= "Jurandir", Email ="jurandir@gmail.com", Telefone ="(65) 4984-9849", CPF ="777.777.777-77", DataCadastro = new DateTime(2023, 10, 3, 20, 28, 26, 290)},
                new Cliente {Id = 2, Nome= "Judit", Email ="judit@gmail.com", Telefone ="(54) 4545-4544", CPF ="544.894.849-98", DataCadastro = new DateTime(2023, 10, 3, 20, 28, 26, 290)},
                new Cliente {Id = 3, Nome= "Astolfo", Email ="astolfo@gmail.com", Telefone ="(92) 98308-7102", CPF ="894.399.251-32", DataCadastro = new DateTime(2023, 10, 3, 20, 28, 26, 290)},
                new Cliente {Id = 5, Nome= "Teobaldo", Email ="manoel@padaria.com", Telefone ="(82) 8959-8598", CPF ="544.484.948-49", DataCadastro = new DateTime(2024, 11, 3, 20, 28, 26, 290)},
                new Cliente {Id = 6, Nome= "Nelson", Email ="nelson@gmail.com", Telefone ="(51) 6165-5551", CPF ="494.292.982-82", DataCadastro = new DateTime(2024, 10, 3, 20, 28, 26, 290)},
                new Cliente {Id = 7, Nome= "Beth", Email ="beth@gmail.com", Telefone ="(54) 4988-5165", CPF ="594.985.982-29", DataCadastro = new DateTime(2024, 10, 3, 20, 28, 26, 290)},
                new Cliente {Id = 8, Nome= "Zezin", Email ="zezin@gmail.com", Telefone ="(59) 8988-8995", CPF ="889.248.484-98"},
                new Cliente {Id = 9, Nome= "Nikita", Email ="nikita@gmail.com", Telefone ="(89) 4494-9849", CPF ="944.984.298-24"},
                new Cliente {Id = 1010, Nome= "Linkedin", Email ="linkedin@gmail.com", Telefone ="(49) 8498-4984", CPF ="984.984.984-84"}
                
            );
        }
    }
}