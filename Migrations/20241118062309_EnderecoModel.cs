using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class EnderecoModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "PontoColeta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 18, 3, 23, 8, 981, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 18, 3, 23, 8, 981, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "Id", "Bairro", "Cep", "Cidade", "Estado", "Numero", "Rua" },
                values: new object[,]
                {
                    { 1, "Bairro 1", "60000-000", "Cidade 1", "Estado 1", 1, "Rua 1" },
                    { 2, "Bairro 2", "60000-001", "Cidade 2", "Estado 2", 2, "Rua 2" }
                });

            migrationBuilder.UpdateData(
                table: "PontoColeta",
                keyColumn: "Id",
                keyValue: 1,
                column: "EnderecoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PontoColeta",
                keyColumn: "Id",
                keyValue: 2,
                column: "EnderecoId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_PontoColeta_EnderecoId",
                table: "PontoColeta",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PontoColeta_Endereco_EnderecoId",
                table: "PontoColeta",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PontoColeta_Endereco_EnderecoId",
                table: "PontoColeta");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_PontoColeta_EnderecoId",
                table: "PontoColeta");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "PontoColeta");

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 18, 1, 33, 37, 574, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 18, 1, 33, 37, 574, DateTimeKind.Local).AddTicks(1278));
        }
    }
}
