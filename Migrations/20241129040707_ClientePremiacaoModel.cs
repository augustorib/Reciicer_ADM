using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class ClientePremiacaoModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Premiacao_Cliente_ClienteId",
                table: "Premiacao");

            migrationBuilder.DropIndex(
                name: "IX_Premiacao_ClienteId",
                table: "Premiacao");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19615d2e-336b-47af-9095-01c057678a32", "7c946a5d-6bed-4ff5-ae66-5ba4991a7260" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "459d7219-fb06-4151-9691-bea34d239ad7", "9d99c30c-86d3-49af-9a63-d3abae6642b3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19615d2e-336b-47af-9095-01c057678a32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "459d7219-fb06-4151-9691-bea34d239ad7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c946a5d-6bed-4ff5-ae66-5ba4991a7260");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d99c30c-86d3-49af-9a63-d3abae6642b3");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Premiacao");

            migrationBuilder.CreateTable(
                name: "ClientePremiacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataOperacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    PremiacaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientePremiacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientePremiacao_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientePremiacao_Premiacao_PremiacaoId",
                        column: x => x.PremiacaoId,
                        principalTable: "Premiacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38c291ac-6d6e-4e48-b67d-cfc60cd5570c", null, "Admin", "ADMIN" },
                    { "7e088983-dbe4-4526-9b48-e6a69db16e5b", null, "Operador", "OPERADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d7db4556-1ba0-4953-80c7-48c3833c7a85", 0, "e40a38d0-11cc-4650-9e85-589965775d9b", "operador@gmail.com", false, false, null, "OPERADOR@GMAIL.COM", "OPERADOR", "AQAAAAIAAYagAAAAEHQ7mga+DIAlOUen1rubIYWrGtJL/2ELlGuZQrZgvy/1u0aPPJa1UHG0VWqHJa06uA==", null, false, "3772dc48-7fd1-4b4e-b79d-651c1ac74e79", false, "operador" },
                    { "f44c1667-b26a-4961-bac1-e6e0e0b84eb7", 0, "d4e1fd86-accd-4868-8f07-bce327316ebb", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAELOGUtUv5slutFj/g2ySNtpAyK6JnEzlfSGIQVH2hL8onfOArNzzqS3hzh4KBbfBlg==", null, false, "9be83c90-b23b-425a-bf20-70f0761cd56a", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CPF", "PontuacaoTotal", "Telefone" },
                values: new object[] { "777.777.777-77", 15, "(65) 4984-9849" });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CPF", "Telefone" },
                values: new object[] { "544.894.849-98", "(54) 4545-4544" });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CPF", "Telefone" },
                values: new object[] { "894.399.251-32", "(92) 98308-7102" });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CNPJ", "Telefone" },
                values: new object[] { "54.594.954/9549-89", "(31) 98371-8402" });

            migrationBuilder.InsertData(
                table: "ClientePremiacao",
                columns: new[] { "Id", "ClienteId", "DataOperacao", "PremiacaoId" },
                values: new object[] { 1, 3, new DateTime(2024, 11, 21, 4, 23, 6, 153, DateTimeKind.Local), 3 });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 29, 1, 7, 5, 988, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 29, 1, 7, 5, 988, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7e088983-dbe4-4526-9b48-e6a69db16e5b", "d7db4556-1ba0-4953-80c7-48c3833c7a85" },
                    { "38c291ac-6d6e-4e48-b67d-cfc60cd5570c", "f44c1667-b26a-4961-bac1-e6e0e0b84eb7" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientePremiacao_ClienteId",
                table: "ClientePremiacao",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientePremiacao_PremiacaoId",
                table: "ClientePremiacao",
                column: "PremiacaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientePremiacao");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7e088983-dbe4-4526-9b48-e6a69db16e5b", "d7db4556-1ba0-4953-80c7-48c3833c7a85" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38c291ac-6d6e-4e48-b67d-cfc60cd5570c", "f44c1667-b26a-4961-bac1-e6e0e0b84eb7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38c291ac-6d6e-4e48-b67d-cfc60cd5570c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e088983-dbe4-4526-9b48-e6a69db16e5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7db4556-1ba0-4953-80c7-48c3833c7a85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f44c1667-b26a-4961-bac1-e6e0e0b84eb7");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Premiacao",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19615d2e-336b-47af-9095-01c057678a32", null, "Admin", "ADMIN" },
                    { "459d7219-fb06-4151-9691-bea34d239ad7", null, "Operador", "OPERADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7c946a5d-6bed-4ff5-ae66-5ba4991a7260", 0, "74f4d6ff-0fcc-4bc7-8459-08f69ec42e93", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAELOGUtUv5slutFj/g2ySNtpAyK6JnEzlfSGIQVH2hL8onfOArNzzqS3hzh4KBbfBlg==", null, false, "9e2899a5-8505-424c-8242-fbefbff34ac1", false, "admin" },
                    { "9d99c30c-86d3-49af-9a63-d3abae6642b3", 0, "a2355ee1-4d4f-4072-9764-008c646a7f3f", "operador@gmail.com", false, false, null, "OPERADOR@GMAIL.COM", "OPERADOR", "AQAAAAIAAYagAAAAEHQ7mga+DIAlOUen1rubIYWrGtJL/2ELlGuZQrZgvy/1u0aPPJa1UHG0VWqHJa06uA==", null, false, "5f77f74b-dad0-40c1-9fa4-d5e510bafc0a", false, "operador" }
                });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CPF", "PontuacaoTotal", "Telefone" },
                values: new object[] { "48906785062", 0, "(85)98792-0782" });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CPF", "Telefone" },
                values: new object[] { "48517494067", "(69)99727-2310" });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CPF", "Telefone" },
                values: new object[] { "71134549504", "(92)98308-7102" });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CNPJ", "Telefone" },
                values: new object[] { "55434549711", "(31)98371-8402" });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 21, 4, 23, 6, 153, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 21, 4, 23, 6, 153, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Premiacao",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClienteId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Premiacao",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClienteId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Premiacao",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClienteId",
                value: 3);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "19615d2e-336b-47af-9095-01c057678a32", "7c946a5d-6bed-4ff5-ae66-5ba4991a7260" },
                    { "459d7219-fb06-4151-9691-bea34d239ad7", "9d99c30c-86d3-49af-9a63-d3abae6642b3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Premiacao_ClienteId",
                table: "Premiacao",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Premiacao_Cliente_ClienteId",
                table: "Premiacao",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id");
        }
    }
}
