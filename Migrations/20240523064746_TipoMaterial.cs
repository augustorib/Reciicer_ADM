using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class TipoMaterial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoDegradacao = table.Column<int>(type: "int", nullable: true),
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoMaterial_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 5, 23, 3, 47, 46, 35, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 5, 23, 3, 47, 46, 35, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.InsertData(
                table: "TipoMaterial",
                columns: new[] { "Id", "Descricao", "MaterialId", "Nome", "TempoDegradacao" },
                values: new object[,]
                {
                    { 1, "Papelão", 2, "Papelão", 162000 },
                    { 2, "Papel de presente", 2, "Papel Presente", 150 },
                    { 3, "Garrafa PET - Polietileno Tereftalato", 1, "PET", 18000 },
                    { 4, "Copo de Vidro", 3, "Copo", 1000000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TipoMaterial_MaterialId",
                table: "TipoMaterial",
                column: "MaterialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoMaterial");

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
        }
    }
}
