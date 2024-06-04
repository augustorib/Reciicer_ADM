using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class AddPremiacaoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_Reciclagem_TipoMaterial_TipoMaterialId",
                table: "Material_Reciclagem");

            migrationBuilder.AlterColumn<int>(
                name: "TipoMaterialId",
                table: "Material_Reciclagem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Premiacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    NivelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Premiacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Premiacao_Nivel_NivelId",
                        column: x => x.NivelId,
                        principalTable: "Nivel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Material_Reciclagem",
                keyColumn: "Id",
                keyValue: 1,
                column: "TipoMaterialId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Premiacao",
                columns: new[] { "Id", "Ativo", "Descricao", "NivelId", "Nome" },
                values: new object[,]
                {
                    { 1, true, "Desconto de 10% na compra", 2, "Desconto 10%" },
                    { 2, true, "Sorteio do carro Fiat", 4, "Sorteio Carro" },
                    { 4, true, "Ingresso para ver Vingadores", 3, "Ingresso Cinema" }
                });

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 6, 3, 21, 31, 48, 285, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 6, 3, 21, 31, 48, 285, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.CreateIndex(
                name: "IX_Premiacao_NivelId",
                table: "Premiacao",
                column: "NivelId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Reciclagem_TipoMaterial_TipoMaterialId",
                table: "Material_Reciclagem",
                column: "TipoMaterialId",
                principalTable: "TipoMaterial",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_Reciclagem_TipoMaterial_TipoMaterialId",
                table: "Material_Reciclagem");

            migrationBuilder.DropTable(
                name: "Premiacao");

            migrationBuilder.AlterColumn<int>(
                name: "TipoMaterialId",
                table: "Material_Reciclagem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Material_Reciclagem",
                keyColumn: "Id",
                keyValue: 1,
                column: "TipoMaterialId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 5, 31, 3, 11, 11, 212, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 5, 31, 3, 11, 11, 212, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Reciclagem_TipoMaterial_TipoMaterialId",
                table: "Material_Reciclagem",
                column: "TipoMaterialId",
                principalTable: "TipoMaterial",
                principalColumn: "Id");
        }
    }
}
