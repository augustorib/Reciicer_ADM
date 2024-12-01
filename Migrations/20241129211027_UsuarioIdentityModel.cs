using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class UsuarioIdentityModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_PontoColeta_PontoColetaId",
                table: "Coleta");

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

            migrationBuilder.DropColumn(
                name: "DataRecolhimento",
                table: "Coleta");

            migrationBuilder.AlterColumn<int>(
                name: "PontoColetaId",
                table: "Coleta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PontoColetaId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9dd6959b-db2e-43b8-8a10-495dde0df27d", null, "Admin", "ADMIN" },
                    { "ace79492-4c2c-4796-8b35-43b55a93c8e6", null, "Operador", "OPERADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PontoColetaId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0761a789-e6e6-4f61-991d-4d73c7145cf2", 0, "fc9239ab-13e5-4bc7-a847-c8ab538a828d", "operador@gmail.com", false, false, null, "OPERADOR@GMAIL.COM", "OPERADOR", "AQAAAAIAAYagAAAAEHQ7mga+DIAlOUen1rubIYWrGtJL/2ELlGuZQrZgvy/1u0aPPJa1UHG0VWqHJa06uA==", null, false, 2, "60d8654f-b7a1-4152-b505-1940de26c413", false, "operador" },
                    { "9e84b8f9-80ba-4639-ae6f-e2749d338067", 0, "30ae6818-fc4a-4e27-b1bc-898050fa909e", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAELOGUtUv5slutFj/g2ySNtpAyK6JnEzlfSGIQVH2hL8onfOArNzzqS3hzh4KBbfBlg==", null, false, 1, "edb3279d-5e75-4205-be1b-1b5d07242a40", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataOperacao", "PontoColetaId" },
                values: new object[] { new DateTime(2024, 11, 29, 18, 10, 26, 776, DateTimeKind.Local).AddTicks(6545), 2 });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataOperacao", "PontoColetaId" },
                values: new object[] { new DateTime(2024, 11, 29, 18, 10, 26, 776, DateTimeKind.Local).AddTicks(6560), 2 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ace79492-4c2c-4796-8b35-43b55a93c8e6", "0761a789-e6e6-4f61-991d-4d73c7145cf2" },
                    { "9dd6959b-db2e-43b8-8a10-495dde0df27d", "9e84b8f9-80ba-4639-ae6f-e2749d338067" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PontoColetaId",
                table: "AspNetUsers",
                column: "PontoColetaId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PontoColeta_PontoColetaId",
                table: "AspNetUsers",
                column: "PontoColetaId",
                principalTable: "PontoColeta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_PontoColeta_PontoColetaId",
                table: "Coleta",
                column: "PontoColetaId",
                principalTable: "PontoColeta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PontoColeta_PontoColetaId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_PontoColeta_PontoColetaId",
                table: "Coleta");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PontoColetaId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ace79492-4c2c-4796-8b35-43b55a93c8e6", "0761a789-e6e6-4f61-991d-4d73c7145cf2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9dd6959b-db2e-43b8-8a10-495dde0df27d", "9e84b8f9-80ba-4639-ae6f-e2749d338067" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dd6959b-db2e-43b8-8a10-495dde0df27d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ace79492-4c2c-4796-8b35-43b55a93c8e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0761a789-e6e6-4f61-991d-4d73c7145cf2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e84b8f9-80ba-4639-ae6f-e2749d338067");

            migrationBuilder.DropColumn(
                name: "PontoColetaId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "PontoColetaId",
                table: "Coleta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DataRecolhimento",
                table: "Coleta",
                type: "date",
                nullable: true);

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
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataOperacao", "DataRecolhimento", "PontoColetaId" },
                values: new object[] { new DateTime(2024, 11, 29, 1, 7, 5, 988, DateTimeKind.Local).AddTicks(8114), null, null });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataOperacao", "DataRecolhimento", "PontoColetaId" },
                values: new object[] { new DateTime(2024, 11, 29, 1, 7, 5, 988, DateTimeKind.Local).AddTicks(8125), null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7e088983-dbe4-4526-9b48-e6a69db16e5b", "d7db4556-1ba0-4953-80c7-48c3833c7a85" },
                    { "38c291ac-6d6e-4e48-b67d-cfc60cd5570c", "f44c1667-b26a-4961-bac1-e6e0e0b84eb7" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_PontoColeta_PontoColetaId",
                table: "Coleta",
                column: "PontoColetaId",
                principalTable: "PontoColeta",
                principalColumn: "Id");
        }
    }
}
