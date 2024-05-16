using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class ReciclagemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PontuacaoTotal",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Reciclagem",
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
                    table.PrimaryKey("PK_Reciclagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reciclagem_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "PontuacaoTotal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "PontuacaoTotal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                column: "PontuacaoTotal",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Nivel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Descricao",
                value: "Iniciante");

            migrationBuilder.InsertData(
                table: "Reciclagem",
                columns: new[] { "Id", "ClienteId", "DataOperacao", "PontuacaoGanha" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 13, 22, 20, 17, 906, DateTimeKind.Local).AddTicks(8817), 10 },
                    { 2, 1, new DateTime(2024, 5, 13, 22, 20, 17, 906, DateTimeKind.Local).AddTicks(8831), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reciclagem_ClienteId",
                table: "Reciclagem",
                column: "ClienteId");

            migrationBuilder.Sql(@"CREATE PROC UpdateClientePontuacaoTotal
                                    AS
                                    BEGIN
                                        UPDATE Cliente
                                        SET PontuacaoTotal = ISNULL((SELECT 
                                                                        Sum(PontuacaoGanha)
                                                                    FROM
                                                                        Reciclagem R 
                                                                        JOIN Cliente C  ON R.ClienteId = C.id AND C.Id = Cliente.Id),0)

                                    END");

            migrationBuilder.Sql(@"CREATE PROCEDURE UpdateClienteNivel
                                    @PontuacaoTotalCliente INT,
                                    @ClienteID INT
                                AS
                                BEGIN
                                    UPDATE Cliente 
                                    SET nivelId = (SELECT TOP 1 
                                                        N.Id
                                                    FROM
                                                        Nivel N
                                                    WHERE
                                                        @PontuacaoTotalCliente >= n.PontuacaoNecessario
                                                    ORDER BY
                                                        N.PontuacaoNecessario DESC)
                                    WHERE 
                                        Cliente.Id = @ClienteID
                                END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reciclagem");

            migrationBuilder.DropColumn(
                name: "PontuacaoTotal",
                table: "Cliente");

            migrationBuilder.UpdateData(
                table: "Nivel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Descricao",
                value: "Iniciannte");

            migrationBuilder.Sql("DROP PROCEDURE UpdateClientePontuacaoTotal");
            migrationBuilder.Sql("DROP PROCEDURE UpdateClienteNivel");
        }
    }
}
