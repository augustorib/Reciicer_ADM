using Reciicer.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Reciicer.Data.Seed
{
    public static class IdentitySeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            var adminRoleId = "298f1256-ec97-4797-966c-d813afa14f70";
            var operadorRoleId = "8a62bbbf-8420-459c-94d3-9da153f3803f";
            var adminUserId = "8868b1f4-812f-4bbd-a438-1b25f7241f78";
            var operadorUserId = "02f34b97-229a-4764-ba00-2298903959c5";

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = operadorRoleId, Name = "Operador", NormalizedName = "OPERADOR" }
            );

            modelBuilder.Entity<UsuarioIdentity>().HasData(
                new UsuarioIdentity { Id = adminUserId, UserName = "admin", NormalizedUserName = "ADMIN", Email = "admin@gmail.com", NormalizedEmail ="ADMIN@GMAIL.COM",PasswordHash = "AQAAAAIAAYagAAAAELOGUtUv5slutFj/g2ySNtpAyK6JnEzlfSGIQVH2hL8onfOArNzzqS3hzh4KBbfBlg==", PontoColetaId=1 },
                new UsuarioIdentity { Id = operadorUserId, UserName = "operador", NormalizedUserName = "OPERADOR", Email = "operador@gmail.com", NormalizedEmail ="OPERADOR@GMAIL.COM", PasswordHash = "AQAAAAIAAYagAAAAEHQ7mga+DIAlOUen1rubIYWrGtJL/2ELlGuZQrZgvy/1u0aPPJa1UHG0VWqHJa06uA==", PontoColetaId = 2 }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = adminUserId, RoleId = adminRoleId },
                new IdentityUserRole<string> { UserId = operadorUserId, RoleId = operadorRoleId }
            );
        }
    }
}