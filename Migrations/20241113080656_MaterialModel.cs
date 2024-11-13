using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class MaterialModel : Migration
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
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TempoDegradacao = table.Column<int>(type: "int", nullable: true),
                    PontuacaoPeso = table.Column<int>(type: "int", nullable: false),
                    PontuacaoUnidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Material",
                columns: new[] { "Id", "Descricao", "Nome", "PontuacaoPeso", "PontuacaoUnidade", "TempoDegradacao" },
                values: new object[,]
                {
                    { 1, "Papelão", "Papelão", 20, 2, 162000 },
                    { 2, "Papel de presente", "Papel Presente", 10, 5, 150 },
                    { 3, "Garrafa PET - Polietileno Tereftalato", "PET", 15, 3, 18000 },
                    { 4, "Copo de Vidro", "Copo", 25, 10, 1000000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Material");
        }
    }
}
