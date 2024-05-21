using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class MaterialReciclagemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Material_Reciclagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    ReciclagemId = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material_Reciclagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Material_Reciclagem_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Material_Reciclagem_Reciclagem_ReciclagemId",
                        column: x => x.ReciclagemId,
                        principalTable: "Reciclagem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Material",
                columns: new[] { "Id", "Ativo", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 1, true, "Plástico", "Plástico" },
                    { 2, true, "Papel", "Papel" },
                    { 3, true, "Vidro", "Vidro" },
                    { 4, true, "Metal", "Metal" }
                });

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 5, 17, 2, 35, 5, 202, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 5, 17, 2, 35, 5, 202, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.InsertData(
                table: "Material_Reciclagem",
                columns: new[] { "Id", "MaterialId", "Peso", "Quantidade", "ReciclagemId" },
                values: new object[] { 1, 2, 5, 0, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Material_Reciclagem_MaterialId",
                table: "Material_Reciclagem",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_Reciclagem_ReciclagemId",
                table: "Material_Reciclagem",
                column: "ReciclagemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Material_Reciclagem");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 5, 13, 22, 20, 17, 906, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 5, 13, 22, 20, 17, 906, DateTimeKind.Local).AddTicks(8831));
        }
    }
}
