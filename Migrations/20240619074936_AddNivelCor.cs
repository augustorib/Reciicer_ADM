using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class AddNivelCor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DataFinal",
                table: "Premiacao",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "DataInicial",
                table: "Premiacao",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Cor",
                table: "Nivel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Nivel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cor",
                value: "#adb5bd");

            migrationBuilder.UpdateData(
                table: "Nivel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cor",
                value: "#0dcaf0");

            migrationBuilder.UpdateData(
                table: "Nivel",
                keyColumn: "Id",
                keyValue: 3,
                column: "Cor",
                value: "#ffc107");

            migrationBuilder.UpdateData(
                table: "Nivel",
                keyColumn: "Id",
                keyValue: 4,
                column: "Cor",
                value: "#198754");

            migrationBuilder.UpdateData(
                table: "Premiacao",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFinal", "DataInicial" },
                values: new object[] { new DateOnly(2024, 6, 30), new DateOnly(2024, 6, 1) });

            migrationBuilder.UpdateData(
                table: "Premiacao",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFinal", "DataInicial" },
                values: new object[] { new DateOnly(2024, 6, 30), new DateOnly(2024, 6, 1) });

            migrationBuilder.UpdateData(
                table: "Premiacao",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFinal", "DataInicial" },
                values: new object[] { new DateOnly(2024, 6, 30), new DateOnly(2024, 6, 1) });

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 6, 19, 4, 49, 35, 350, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 6, 19, 4, 49, 35, 350, DateTimeKind.Local).AddTicks(1076));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataFinal",
                table: "Premiacao");

            migrationBuilder.DropColumn(
                name: "DataInicial",
                table: "Premiacao");

            migrationBuilder.DropColumn(
                name: "Cor",
                table: "Nivel");

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 6, 5, 0, 13, 14, 204, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 6, 5, 0, 13, 14, 204, DateTimeKind.Local).AddTicks(5679));
        }
    }
}
