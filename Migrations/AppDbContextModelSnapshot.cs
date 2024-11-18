﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reciicer.Data;

#nullable disable

namespace Reciicer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontuacaoTotal")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CPF = "48906785062",
                            Email = "jurandir@gmail.com",
                            Nome = "Jurandir",
                            PontuacaoTotal = 0,
                            Telefone = "(85)98792-0782"
                        },
                        new
                        {
                            Id = 2,
                            CPF = "48517494067",
                            Email = "judit@gmail.com",
                            Nome = "Judit",
                            PontuacaoTotal = 0,
                            Telefone = "(69)99727-2310"
                        },
                        new
                        {
                            Id = 3,
                            CPF = "71134549504",
                            Email = "astolfo@gmail.com",
                            Nome = "Astolfo",
                            PontuacaoTotal = 0,
                            Telefone = "(92)98308-7102"
                        },
                        new
                        {
                            Id = 4,
                            CNPJ = "55434549711",
                            Email = "manoel@padaria.com",
                            Nome = "Padaria Manoel",
                            PontuacaoTotal = 0,
                            Telefone = "(31)98371-8402"
                        });
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Coleta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataOperacao")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly?>("DataRecolhimento")
                        .HasColumnType("date");

                    b.Property<int?>("PontoColetaId")
                        .HasColumnType("int");

                    b.Property<int>("PontuacaoGanha")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PontoColetaId");

                    b.ToTable("Coleta");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 1,
                            DataOperacao = new DateTime(2024, 11, 18, 1, 33, 37, 574, DateTimeKind.Local).AddTicks(1263),
                            PontuacaoGanha = 10
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 1,
                            DataOperacao = new DateTime(2024, 11, 18, 1, 33, 37, 574, DateTimeKind.Local).AddTicks(1278),
                            PontuacaoGanha = 5
                        });
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontuacaoPeso")
                        .HasColumnType("int");

                    b.Property<int>("PontuacaoUnidade")
                        .HasColumnType("int");

                    b.Property<int?>("TempoDegradacao")
                        .HasColumnType("int");

                    b.Property<int>("TipoMaterialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoMaterialId");

                    b.ToTable("Material");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Papelão",
                            Nome = "Papelão",
                            PontuacaoPeso = 20,
                            PontuacaoUnidade = 2,
                            TempoDegradacao = 162000,
                            TipoMaterialId = 2
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Papel de presente",
                            Nome = "Papel Presente",
                            PontuacaoPeso = 10,
                            PontuacaoUnidade = 5,
                            TempoDegradacao = 150,
                            TipoMaterialId = 2
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Garrafa PET - Polietileno Tereftalato",
                            Nome = "PET",
                            PontuacaoPeso = 15,
                            PontuacaoUnidade = 3,
                            TempoDegradacao = 18000,
                            TipoMaterialId = 1
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Copo de Vidro",
                            Nome = "Copo",
                            PontuacaoPeso = 25,
                            PontuacaoUnidade = 10,
                            TempoDegradacao = 1000000,
                            TipoMaterialId = 3
                        });
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Material_Coleta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ColetaId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColetaId");

                    b.HasIndex("MaterialId");

                    b.ToTable("Material_Coleta");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColetaId = 1,
                            MaterialId = 3,
                            Peso = 5,
                            Quantidade = 0
                        });
                });

            modelBuilder.Entity("Reciicer.Models.Entities.PontoColeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PontoColeta");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Parmê"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Supermercado Guanabara"
                        });
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Premiacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontuacaoRequerida")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Premiacao");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            Descricao = "Ingresso para 1 sessão de cinema",
                            Nome = "Ingresso UCI",
                            PontuacaoRequerida = 1000
                        },
                        new
                        {
                            Id = 2,
                            Ativo = false,
                            Descricao = "Desconto de 10% em compras até R$200,00 ",
                            Nome = "Desconto 10%",
                            PontuacaoRequerida = 100
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            ClienteId = 3,
                            Descricao = "Boné personalizado ",
                            Nome = "Boné",
                            PontuacaoRequerida = 200
                        });
                });

            modelBuilder.Entity("Reciicer.Models.Entities.TipoMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoMaterial");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            Descricao = "Plástico",
                            Nome = "Plástico"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            Descricao = "Papel",
                            Nome = "Papel"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            Descricao = "Vidro",
                            Nome = "Vidro"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            Descricao = "Metal",
                            Nome = "Metal"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Coleta", b =>
                {
                    b.HasOne("Reciicer.Models.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reciicer.Models.Entities.PontoColeta", null)
                        .WithMany("Coletas")
                        .HasForeignKey("PontoColetaId");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Material", b =>
                {
                    b.HasOne("Reciicer.Models.Entities.TipoMaterial", "TipoMaterial")
                        .WithMany("Materiais")
                        .HasForeignKey("TipoMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoMaterial");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Material_Coleta", b =>
                {
                    b.HasOne("Reciicer.Models.Entities.Coleta", "Coleta")
                        .WithMany("Material_Coletas")
                        .HasForeignKey("ColetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reciicer.Models.Entities.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coleta");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Premiacao", b =>
                {
                    b.HasOne("Reciicer.Models.Entities.Cliente", "cliente")
                        .WithMany("Premios")
                        .HasForeignKey("ClienteId");

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Cliente", b =>
                {
                    b.Navigation("Premios");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Coleta", b =>
                {
                    b.Navigation("Material_Coletas");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.PontoColeta", b =>
                {
                    b.Navigation("Coletas");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.TipoMaterial", b =>
                {
                    b.Navigation("Materiais");
                });
#pragma warning restore 612, 618
        }
    }
}
