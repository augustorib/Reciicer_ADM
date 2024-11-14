using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class ColetaModelAndJoinTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coleta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataOperacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PontuacaoGanha = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coleta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coleta_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Material_Coleta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    ColetaId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material_Coleta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Material_Coleta_Coleta_ColetaId",
                        column: x => x.ColetaId,
                        principalTable: "Coleta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Material_Coleta_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Coleta",
                columns: new[] { "Id", "ClienteId", "DataOperacao", "PontuacaoGanha" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 11, 14, 0, 22, 53, 704, DateTimeKind.Local).AddTicks(7055), 10 },
                    { 2, 1, new DateTime(2024, 11, 14, 0, 22, 53, 704, DateTimeKind.Local).AddTicks(7066), 5 }
                });

            migrationBuilder.InsertData(
                table: "Material_Coleta",
                columns: new[] { "Id", "ColetaId", "MaterialId", "Peso", "Quantidade" },
                values: new object[] { 1, 1, 3, 5, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Coleta_ClienteId",
                table: "Coleta",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_Coleta_ColetaId",
                table: "Material_Coleta",
                column: "ColetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_Coleta_MaterialId",
                table: "Material_Coleta",
                column: "MaterialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Material_Coleta");

            migrationBuilder.DropTable(
                name: "Coleta");
        }
    }
}
