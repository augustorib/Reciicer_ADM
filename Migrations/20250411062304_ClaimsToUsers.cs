using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class ClaimsToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Admin", "8868b1f4-812f-4bbd-a438-1b25f7241f78" },
                    { 2, "PontoColetaId", "1", "8868b1f4-812f-4bbd-a438-1b25f7241f78" },
                    { 3, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Operador", "02f34b97-229a-4764-ba00-2298903959c5" },
                    { 4, "PontoColetaId", "2", "02f34b97-229a-4764-ba00-2298903959c5" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f34b97-229a-4764-ba00-2298903959c5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f12cf188-c695-45d3-aaaf-537139b5a18f", "0498db86-a723-4b9a-a0d5-ab6707cc2526" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8868b1f4-812f-4bbd-a438-1b25f7241f78",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94df1e4c-d489-4694-9cfc-975d8a82d055", "b0d98ed2-efb3-4d43-99ea-bc5048a9f79e" });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2023, 10, 3, 20, 28, 26, 290, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2023, 10, 3, 20, 28, 26, 290, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2023, 10, 3, 20, 28, 26, 290, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f34b97-229a-4764-ba00-2298903959c5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5dfdbb8-9088-49b4-933e-e1d154427f1f", "fab025e8-e129-4a69-b186-f415e5ee9fc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8868b1f4-812f-4bbd-a438-1b25f7241f78",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6448e1e6-bff3-433a-bc51-ddd8a2b3bfe2", "9c5d5c7f-e48a-4f04-b6d2-f94aae425bf4" });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
