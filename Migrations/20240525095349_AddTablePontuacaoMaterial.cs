using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class AddTablePontuacaoMaterial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TipoMaterial",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "TipoMaterial",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "PontuacaoMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PontuacaoPeso = table.Column<int>(type: "int", nullable: false),
                    PontuacaoUnidade = table.Column<int>(type: "int", nullable: false),
                    TipoMaterialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontuacaoMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PontuacaoMaterial_TipoMaterial_TipoMaterialId",
                        column: x => x.TipoMaterialId,
                        principalTable: "TipoMaterial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PontuacaoMaterial",
                columns: new[] { "Id", "PontuacaoPeso", "PontuacaoUnidade", "TipoMaterialId" },
                values: new object[,]
                {
                    { 1, 20, 2, 2 },
                    { 2, 100, 10, 4 },
                    { 3, 50, 5, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 5, 25, 6, 53, 48, 740, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 5, 25, 6, 53, 48, 740, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.CreateIndex(
                name: "IX_PontuacaoMaterial_TipoMaterialId",
                table: "PontuacaoMaterial",
                column: "TipoMaterialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PontuacaoMaterial");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TipoMaterial",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "TipoMaterial",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
