using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class InittialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nivel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PontuacaoNecessario = table.Column<int>(type: "int", nullable: false),
                    PontosPerdaFrequencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nivel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NivelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Nivel_NivelId",
                        column: x => x.NivelId,
                        principalTable: "Nivel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Nivel",
                columns: new[] { "Id", "Descricao", "PontosPerdaFrequencia", "PontuacaoNecessario" },
                values: new object[,]
                {
                    { 1, "Iniciannte", 0, 0 },
                    { 2, "Básico", 2, 10 },
                    { 3, "Intermediário", 10, 50 },
                    { 4, "Avançado", 20, 200 }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "CPF", "Email", "NivelId", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "48906785062", "jurandir@gmail.com", 3, "Jurandir", "(85)98792-0782" },
                    { 2, "48517494067", "judit@gmail.com", 2, "Judit", "(69)99727-2310" },
                    { 3, "71134549504", "astolfo@gmail.com", 4, "Astolfo", "(92)98308-7102" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_NivelId",
                table: "Cliente",
                column: "NivelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Nivel");
        }
    }
}
