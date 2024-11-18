using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class PontoColetaModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DataRecolhimento",
                table: "Coleta",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PontoColetaId",
                table: "Coleta",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PontoColeta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontoColeta", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataOperacao", "DataRecolhimento", "PontoColetaId" },
                values: new object[] { new DateTime(2024, 11, 18, 1, 33, 37, 574, DateTimeKind.Local).AddTicks(1263), null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataOperacao", "DataRecolhimento", "PontoColetaId" },
                values: new object[] { new DateTime(2024, 11, 18, 1, 33, 37, 574, DateTimeKind.Local).AddTicks(1278), null, null });

            migrationBuilder.InsertData(
                table: "PontoColeta",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Parmê" },
                    { 2, "Supermercado Guanabara" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coleta_PontoColetaId",
                table: "Coleta",
                column: "PontoColetaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_PontoColeta_PontoColetaId",
                table: "Coleta",
                column: "PontoColetaId",
                principalTable: "PontoColeta",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_PontoColeta_PontoColetaId",
                table: "Coleta");

            migrationBuilder.DropTable(
                name: "PontoColeta");

            migrationBuilder.DropIndex(
                name: "IX_Coleta_PontoColetaId",
                table: "Coleta");

            migrationBuilder.DropColumn(
                name: "DataRecolhimento",
                table: "Coleta");

            migrationBuilder.DropColumn(
                name: "PontoColetaId",
                table: "Coleta");

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 14, 0, 22, 53, 704, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 14, 0, 22, 53, 704, DateTimeKind.Local).AddTicks(7066));
        }
    }
}
