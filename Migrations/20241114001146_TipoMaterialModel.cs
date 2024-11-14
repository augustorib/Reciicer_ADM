using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class TipoMaterialModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoMaterialId",
                table: "Material",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TipoMaterial",
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
                    table.PrimaryKey("PK_TipoMaterial", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "Id",
                keyValue: 1,
                column: "TipoMaterialId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "Id",
                keyValue: 2,
                column: "TipoMaterialId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "Id",
                keyValue: 3,
                column: "TipoMaterialId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "Id",
                keyValue: 4,
                column: "TipoMaterialId",
                value: 3);

            migrationBuilder.InsertData(
                table: "TipoMaterial",
                columns: new[] { "Id", "Ativo", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 1, true, "Plástico", "Plástico" },
                    { 2, true, "Papel", "Papel" },
                    { 3, true, "Vidro", "Vidro" },
                    { 4, true, "Metal", "Metal" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Material_TipoMaterialId",
                table: "Material",
                column: "TipoMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_TipoMaterial_TipoMaterialId",
                table: "Material",
                column: "TipoMaterialId",
                principalTable: "TipoMaterial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_TipoMaterial_TipoMaterialId",
                table: "Material");

            migrationBuilder.DropTable(
                name: "TipoMaterial");

            migrationBuilder.DropIndex(
                name: "IX_Material_TipoMaterialId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "TipoMaterialId",
                table: "Material");
        }
    }
}
