﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reciicer.Data;

#nullable disable

namespace Reciicer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240525095349_AddTablePontuacaoMaterial")]
    partial class AddTablePontuacaoMaterial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Reciicer.Models.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NivelId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontuacaoTotal")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NivelId");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CPF = "48906785062",
                            Email = "jurandir@gmail.com",
                            NivelId = 3,
                            Nome = "Jurandir",
                            PontuacaoTotal = 0,
                            Telefone = "(85)98792-0782"
                        },
                        new
                        {
                            Id = 2,
                            CPF = "48517494067",
                            Email = "judit@gmail.com",
                            NivelId = 2,
                            Nome = "Judit",
                            PontuacaoTotal = 0,
                            Telefone = "(69)99727-2310"
                        },
                        new
                        {
                            Id = 3,
                            CPF = "71134549504",
                            Email = "astolfo@gmail.com",
                            NivelId = 4,
                            Nome = "Astolfo",
                            PontuacaoTotal = 0,
                            Telefone = "(92)98308-7102"
                        });
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Material", b =>
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

                    b.ToTable("Material");

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

            modelBuilder.Entity("Reciicer.Models.Entities.Material_Reciclagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("ReciclagemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.HasIndex("ReciclagemId");

                    b.ToTable("Material_Reciclagem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MaterialId = 2,
                            Peso = 5,
                            Quantidade = 0,
                            ReciclagemId = 1
                        });
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Nivel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontosPerdaFrequencia")
                        .HasColumnType("int");

                    b.Property<int>("PontuacaoNecessario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Nivel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Iniciante",
                            PontosPerdaFrequencia = 0,
                            PontuacaoNecessario = 0
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Básico",
                            PontosPerdaFrequencia = 2,
                            PontuacaoNecessario = 10
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Intermediário",
                            PontosPerdaFrequencia = 10,
                            PontuacaoNecessario = 50
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Avançado",
                            PontosPerdaFrequencia = 20,
                            PontuacaoNecessario = 200
                        });
                });

            modelBuilder.Entity("Reciicer.Models.Entities.PontuacaoMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PontuacaoPeso")
                        .HasColumnType("int");

                    b.Property<int>("PontuacaoUnidade")
                        .HasColumnType("int");

                    b.Property<int>("TipoMaterialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoMaterialId");

                    b.ToTable("PontuacaoMaterial");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PontuacaoPeso = 20,
                            PontuacaoUnidade = 2,
                            TipoMaterialId = 2
                        },
                        new
                        {
                            Id = 2,
                            PontuacaoPeso = 100,
                            PontuacaoUnidade = 10,
                            TipoMaterialId = 4
                        },
                        new
                        {
                            Id = 3,
                            PontuacaoPeso = 50,
                            PontuacaoUnidade = 5,
                            TipoMaterialId = 1
                        });
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Reciclagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataOperacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("PontuacaoGanha")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Reciclagem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 1,
                            DataOperacao = new DateTime(2024, 5, 25, 6, 53, 48, 740, DateTimeKind.Local).AddTicks(3780),
                            PontuacaoGanha = 10
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 1,
                            DataOperacao = new DateTime(2024, 5, 25, 6, 53, 48, 740, DateTimeKind.Local).AddTicks(3790),
                            PontuacaoGanha = 5
                        });
                });

            modelBuilder.Entity("Reciicer.Models.Entities.TipoMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TempoDegradacao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.ToTable("TipoMaterial");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Papelão",
                            MaterialId = 2,
                            Nome = "Papelão",
                            TempoDegradacao = 162000
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Papel de presente",
                            MaterialId = 2,
                            Nome = "Papel Presente",
                            TempoDegradacao = 150
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Garrafa PET - Polietileno Tereftalato",
                            MaterialId = 1,
                            Nome = "PET",
                            TempoDegradacao = 18000
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Copo de Vidro",
                            MaterialId = 3,
                            Nome = "Copo",
                            TempoDegradacao = 1000000
                        });
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Cliente", b =>
                {
                    b.HasOne("Reciicer.Models.Entities.Nivel", "Nivel")
                        .WithMany("Clientes")
                        .HasForeignKey("NivelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nivel");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Material_Reciclagem", b =>
                {
                    b.HasOne("Reciicer.Models.Entities.Material", "Material")
                        .WithMany("Material_Reciclagems")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reciicer.Models.Entities.Reciclagem", "Reciclagem")
                        .WithMany("Material_Reciclagems")
                        .HasForeignKey("ReciclagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Reciclagem");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.PontuacaoMaterial", b =>
                {
                    b.HasOne("Reciicer.Models.Entities.TipoMaterial", "TipoMaterial")
                        .WithMany()
                        .HasForeignKey("TipoMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoMaterial");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Reciclagem", b =>
                {
                    b.HasOne("Reciicer.Models.Entities.Cliente", "Cliente")
                        .WithMany("Reciclagems")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.TipoMaterial", b =>
                {
                    b.HasOne("Reciicer.Models.Entities.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Cliente", b =>
                {
                    b.Navigation("Reciclagems");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Material", b =>
                {
                    b.Navigation("Material_Reciclagems");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Nivel", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("Reciicer.Models.Entities.Reciclagem", b =>
                {
                    b.Navigation("Material_Reciclagems");
                });
#pragma warning restore 612, 618
        }
    }
}
