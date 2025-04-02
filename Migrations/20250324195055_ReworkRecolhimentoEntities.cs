using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class ReworkRecolhimentoEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recolhimento_PontoColeta_PontoColetaId",
                table: "Recolhimento");

            migrationBuilder.AlterColumn<int>(
                name: "PontoColetaId",
                table: "Recolhimento",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "RecolhimentoEstoqueMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecolhimentoId = table.Column<int>(type: "int", nullable: false),
                    EstoqueMaterialId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecolhimentoEstoqueMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecolhimentoEstoqueMaterial_EstoqueMaterial_EstoqueMaterialId",
                        column: x => x.EstoqueMaterialId,
                        principalTable: "EstoqueMaterial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecolhimentoEstoqueMaterial_Recolhimento_RecolhimentoId",
                        column: x => x.RecolhimentoId,
                        principalTable: "Recolhimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f34b97-229a-4764-ba00-2298903959c5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cdd0f7b6-9bba-4422-9328-9845eed3d054", "f2f39961-af59-414d-8188-a60913060d00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8868b1f4-812f-4bbd-a438-1b25f7241f78",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42903dbf-3571-45b1-89af-747db8e03ab9", "2aaf02f3-e468-4835-b70c-204e99e3a6bd" });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 24, 16, 50, 54, 765, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 24, 16, 50, 54, 765, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 24, 16, 50, 54, 765, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 24, 16, 50, 54, 765, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2025, 3, 24, 16, 50, 54, 765, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2025, 3, 24, 16, 50, 54, 765, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 1,
                column: "PontoColetaId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 2,
                column: "PontoColetaId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_RecolhimentoEstoqueMaterial_EstoqueMaterialId",
                table: "RecolhimentoEstoqueMaterial",
                column: "EstoqueMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_RecolhimentoEstoqueMaterial_RecolhimentoId",
                table: "RecolhimentoEstoqueMaterial",
                column: "RecolhimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recolhimento_PontoColeta_PontoColetaId",
                table: "Recolhimento",
                column: "PontoColetaId",
                principalTable: "PontoColeta",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recolhimento_PontoColeta_PontoColetaId",
                table: "Recolhimento");

            migrationBuilder.DropTable(
                name: "RecolhimentoEstoqueMaterial");

            migrationBuilder.AlterColumn<int>(
                name: "PontoColetaId",
                table: "Recolhimento",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f34b97-229a-4764-ba00-2298903959c5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82e5346b-fcf8-4100-bccd-60f8da412209", "9982ee91-1e94-44e8-98d1-c6d34f3c93cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8868b1f4-812f-4bbd-a438-1b25f7241f78",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56006c13-7319-448b-8bc1-075f25634e32", "4c55f438-7920-4646-92c3-b39357247a18" });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 17, 3, 10, 24, 25, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 17, 3, 10, 24, 25, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 17, 3, 10, 24, 25, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 17, 3, 10, 24, 25, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2025, 3, 17, 3, 10, 24, 26, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2025, 3, 17, 3, 10, 24, 26, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 1,
                column: "PontoColetaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 2,
                column: "PontoColetaId",
                value: 2);

            migrationBuilder.AddForeignKey(
                name: "FK_Recolhimento_PontoColeta_PontoColetaId",
                table: "Recolhimento",
                column: "PontoColetaId",
                principalTable: "PontoColeta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
