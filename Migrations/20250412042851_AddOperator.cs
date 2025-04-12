using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class AddOperator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "8868b1f4-812f-4bbd-a438-1b25f7241f78",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f34b97-229a-4764-ba00-2298903959c5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "37f70293-3bfc-4f70-8f01-f9710d3d6d6a", "4a929988-d15b-4bda-8d23-cb30ba852611" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8868b1f4-812f-4bbd-a438-1b25f7241f78",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "061e5273-5d5d-4a4a-a394-2ee3dc910673", "35b1d119-efe5-4e5a-ab9e-4eaa92ba7be9" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PontoColetaId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c6b63962-b8ae-440b-b396-7c279fc00a65", 0, "75b041b6-3a0b-4e00-b8d0-b12388128d61", "goku@gmail.com", false, false, null, "GOKU@GMAIL.COM", "GOKU", "AQAAAAIAAYagAAAAEFVovPC6/IgInBQyzn23KHGYw8xpexogmm3uwut00seoRzsW0YQW4GHBf1pNtdPl2w==", null, false, 2, "757f563b-cc3e-4a78-8310-33708c819e84", false, "goku" });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedBy",
                value: "8868b1f4-812f-4bbd-a438-1b25f7241f78");

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedBy",
                value: "8868b1f4-812f-4bbd-a438-1b25f7241f78");

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedBy",
                value: "8868b1f4-812f-4bbd-a438-1b25f7241f78");

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedBy",
                value: "8868b1f4-812f-4bbd-a438-1b25f7241f78");

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedBy",
                value: "8868b1f4-812f-4bbd-a438-1b25f7241f78");

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedBy",
                value: "8868b1f4-812f-4bbd-a438-1b25f7241f78");

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedBy",
                value: "8868b1f4-812f-4bbd-a438-1b25f7241f78");

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedBy",
                value: "8868b1f4-812f-4bbd-a438-1b25f7241f78");

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedBy",
                value: "8868b1f4-812f-4bbd-a438-1b25f7241f78");

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 5, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Operador", "c6b63962-b8ae-440b-b396-7c279fc00a65" },
                    { 6, "PontoColetaId", "2", "c6b63962-b8ae-440b-b396-7c279fc00a65" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8a62bbbf-8420-459c-94d3-9da153f3803f", "c6b63962-b8ae-440b-b396-7c279fc00a65" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8a62bbbf-8420-459c-94d3-9da153f3803f", "c6b63962-b8ae-440b-b396-7c279fc00a65" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6b63962-b8ae-440b-b396-7c279fc00a65");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "8868b1f4-812f-4bbd-a438-1b25f7241f78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f34b97-229a-4764-ba00-2298903959c5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b3e54c7-8c70-4d20-9820-96fad61cd9d0", "be260f41-b82c-47fe-9051-e78ed3500d00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8868b1f4-812f-4bbd-a438-1b25f7241f78",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1baef787-8bf1-4f46-a40d-7cce9cc00a4e", "5aa8cd4a-9c6d-476c-a246-56de4783a6e5" });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedBy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedBy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedBy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedBy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedBy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedBy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedBy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedBy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1010,
                column: "CreatedBy",
                value: null);
        }
    }
}
