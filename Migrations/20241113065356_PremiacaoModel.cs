using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class PremiacaoModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Premiacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PontuacaoRequerida = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Premiacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Premiacao_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Premiacao",
                columns: new[] { "Id", "Ativo", "ClienteId", "Descricao", "Nome", "PontuacaoRequerida" },
                values: new object[,]
                {
                    { 1, true, null, "Ingresso para 1 sessão de cinema", "Ingresso UCI", 1000 },
                    { 2, false, null, "Desconto de 10% em compras até R$200,00 ", "Desconto 10%", 100 },
                    { 3, true, 3, "Boné personalizado ", "Boné", 200 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Premiacao_ClienteId",
                table: "Premiacao",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Premiacao");
        }
    }
}
