using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class AuditInformations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "TipoMaterial",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TipoMaterial",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "TipoMaterial",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "TipoMaterial",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "RecolhimentoEstoqueMaterial",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "RecolhimentoEstoqueMaterial",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "RecolhimentoEstoqueMaterial",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "RecolhimentoEstoqueMaterial",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Recolhimento",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Recolhimento",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Recolhimento",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Recolhimento",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Premiacao",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Premiacao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Premiacao",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Premiacao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PontoColeta",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PontoColeta",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "PontoColeta",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "PontoColeta",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Material_Coleta",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Material_Coleta",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Material_Coleta",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Material_Coleta",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Material",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Material",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Material",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Material",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "EstoqueMaterial",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EstoqueMaterial",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "EstoqueMaterial",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "EstoqueMaterial",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Estoque",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Estoque",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Estoque",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Estoque",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Endereco",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Endereco",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Cooperativa",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Cooperativa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Cooperativa",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Cooperativa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Coleta",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Coleta",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Coleta",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Coleta",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ClientePremiacao",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ClientePremiacao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ClientePremiacao",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ClientePremiacao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Cliente",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Cliente",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AuditLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tabela = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistroId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Changes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLog", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f34b97-229a-4764-ba00-2298903959c5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b3e54c7-8c70-4d20-9820-96fad61cd9d0", "be260f41-b82c-47fe-9051-e78ed3500d00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8868b1f4-812f-4bbd-a438-1b25f7241f78",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1baef787-8bf1-4f46-a40d-7cce9cc00a4e", "5aa8cd4a-9c6d-476c-a246-56de4783a6e5" });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "ClientePremiacao",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "ClientePremiacao",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "ClientePremiacao",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "ClientePremiacao",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "ClientePremiacao",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2085,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2090,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2091,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2092,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 3090,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 3091,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 3092,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 4103,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 4105,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Cooperativa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Cooperativa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Estoque",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Estoque",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Estoque",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Estoque",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1165,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1166,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1167,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1168,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1169,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2163,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2164,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2165,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2166,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2167,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2168,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2169,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2170,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2171,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2172,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2173,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2174,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2175,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2176,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2177,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2178,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2179,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2180,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2181,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2182,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 2114,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 3119,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 3120,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 3121,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 4133,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "PontoColeta",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "PontoColeta",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Premiacao",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Premiacao",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Premiacao",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "RecolhimentoEstoqueMaterial",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "RecolhimentoEstoqueMaterial",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "RecolhimentoEstoqueMaterial",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "RecolhimentoEstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "RecolhimentoEstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "TipoMaterial",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "TipoMaterial",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "TipoMaterial",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "TipoMaterial",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[] { null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLog");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "TipoMaterial");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TipoMaterial");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "TipoMaterial");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "TipoMaterial");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "RecolhimentoEstoqueMaterial");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "RecolhimentoEstoqueMaterial");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "RecolhimentoEstoqueMaterial");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "RecolhimentoEstoqueMaterial");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Recolhimento");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Recolhimento");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Recolhimento");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Recolhimento");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Premiacao");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Premiacao");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Premiacao");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Premiacao");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PontoColeta");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PontoColeta");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "PontoColeta");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "PontoColeta");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Material_Coleta");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Material_Coleta");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Material_Coleta");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Material_Coleta");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "EstoqueMaterial");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EstoqueMaterial");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "EstoqueMaterial");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EstoqueMaterial");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Estoque");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Estoque");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Estoque");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Estoque");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Cooperativa");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Cooperativa");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Cooperativa");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Cooperativa");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Coleta");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Coleta");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Coleta");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Coleta");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ClientePremiacao");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ClientePremiacao");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ClientePremiacao");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ClientePremiacao");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Cliente");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f34b97-229a-4764-ba00-2298903959c5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f12cf188-c695-45d3-aaaf-537139b5a18f", "0498db86-a723-4b9a-a0d5-ab6707cc2526" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8868b1f4-812f-4bbd-a438-1b25f7241f78",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94df1e4c-d489-4694-9cfc-975d8a82d055", "b0d98ed2-efb3-4d43-99ea-bc5048a9f79e" });
        }
    }
}
