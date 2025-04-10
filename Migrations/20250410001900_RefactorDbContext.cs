using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class RefactorDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recolhimento_PontoColeta_PontoColetaId",
                table: "Recolhimento");

            migrationBuilder.DropTable(
                name: "RecolhimentoMaterial");

            migrationBuilder.DropIndex(
                name: "IX_Recolhimento_PontoColetaId",
                table: "Recolhimento");

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "PontoColetaId",
                table: "Recolhimento");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Coleta");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TipoMaterial",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "TipoMaterial",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "TipoMaterial",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Premiacao",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Premiacao",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "PontoColeta",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TempoDegradacao",
                table: "Material",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Material",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Material",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Endereco",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Endereco",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Endereco",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Endereco",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Endereco",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cooperativa",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cooperativa",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Cooperativa",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Cliente",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PontuacaoTotal",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Cliente",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Cliente",
                type: "nvarchar(18)",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "DataCadastro", "PontuacaoTotal" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

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

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "CNPJ", "CPF", "DataCadastro", "Email", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 5, null, "544.484.948-49", new DateTime(2024, 11, 3, 20, 28, 26, 290, DateTimeKind.Unspecified), "manoel@padaria.com", "Teobaldo", "(82) 8959-8598" },
                    { 6, null, "494.292.982-82", new DateTime(2024, 10, 3, 20, 28, 26, 290, DateTimeKind.Unspecified), "nelson@gmail.com", "Nelson", "(51) 6165-5551" },
                    { 7, null, "594.985.982-29", new DateTime(2024, 10, 3, 20, 28, 26, 290, DateTimeKind.Unspecified), "beth@gmail.com", "Beth", "(54) 4988-5165" }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "CNPJ", "CPF", "Email", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 8, null, "889.248.484-98", "zezin@gmail.com", "Zezin", "(59) 8988-8995" },
                    { 9, null, "944.984.298-24", "nikita@gmail.com", "Nikita", "(89) 4494-9849" },
                    { 1010, null, "984.984.984-84", "linkedin@gmail.com", "Linkedin", "(49) 8498-4984" }
                });

            migrationBuilder.InsertData(
                table: "ClientePremiacao",
                columns: new[] { "Id", "ClienteId", "DataOperacao", "PremiacaoId" },
                values: new object[] { 2, 2, new DateTime(2024, 12, 3, 20, 21, 1, 913, DateTimeKind.Local), 3 });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2025, 3, 24, 16, 50, 54, 765, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Coleta",
                columns: new[] { "Id", "ClienteId", "DataOperacao", "PontoColetaId", "PontuacaoGanha" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2024, 9, 4, 20, 8, 0, 0, DateTimeKind.Unspecified), 1, 54 },
                    { 4, 3, new DateTime(2024, 10, 17, 20, 9, 0, 0, DateTimeKind.Unspecified), 1, 20 },
                    { 5, 1, new DateTime(2024, 11, 17, 20, 10, 0, 0, DateTimeKind.Unspecified), 1, 6 },
                    { 6, 1, new DateTime(2024, 11, 22, 20, 11, 0, 0, DateTimeKind.Unspecified), 1, 150 },
                    { 7, 2, new DateTime(2024, 12, 3, 20, 20, 0, 0, DateTimeKind.Unspecified), 1, 115 },
                    { 8, 2, new DateTime(2024, 12, 2, 20, 20, 0, 0, DateTimeKind.Unspecified), 1, 200 },
                    { 12, 3, new DateTime(2024, 12, 11, 0, 21, 0, 0, DateTimeKind.Unspecified), 1, 250 },
                    { 1017, 1, new DateTime(2023, 3, 12, 18, 41, 0, 0, DateTimeKind.Unspecified), 1, 75 },
                    { 2085, 1, new DateTime(2025, 3, 4, 1, 57, 0, 0, DateTimeKind.Unspecified), 1, 120 },
                    { 2091, 2, new DateTime(2025, 3, 13, 3, 41, 0, 0, DateTimeKind.Unspecified), 1, 0 },
                    { 2092, 2, new DateTime(2025, 3, 5, 3, 42, 0, 0, DateTimeKind.Unspecified), 1, 0 },
                    { 3090, 1, new DateTime(2025, 3, 20, 19, 2, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 3091, 2, new DateTime(2025, 2, 26, 19, 40, 0, 0, DateTimeKind.Unspecified), 1, 90 },
                    { 3092, 1, new DateTime(2025, 3, 18, 19, 41, 0, 0, DateTimeKind.Unspecified), 1, 120 },
                    { 4103, 2, new DateTime(2025, 3, 4, 17, 10, 0, 0, DateTimeKind.Unspecified), 1, 20 },
                    { 4105, 1, new DateTime(2025, 3, 6, 19, 51, 0, 0, DateTimeKind.Unspecified), 1, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Cooperativa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CNPJ", "Email" },
                values: new object[] { "00.000.000", "coop@gmail.com" });

            migrationBuilder.InsertData(
                table: "Cooperativa",
                columns: new[] { "Id", "CNPJ", "Email", "Nome" },
                values: new object[] { 2, "48489484848", "comlurb@gmail.com", "Comlurb" });

            migrationBuilder.UpdateData(
                table: "Estoque",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacidade", "PesoArmazenado", "QuantidadeArmazenada" },
                values: new object[] { 20, 4, 16 });

            migrationBuilder.InsertData(
                table: "Estoque",
                columns: new[] { "Id", "Capacidade", "Codigo", "PesoArmazenado", "PontoColetaId", "QuantidadeArmazenada", "Tipo" },
                values: new object[,]
                {
                    { 1007, 10, "PN002", 3, 1, 6, "Normal" },
                    { 1008, 10, "PN003", 2, 1, 0, "Normal" }
                });

            migrationBuilder.InsertData(
                table: "EstoqueMaterial",
                columns: new[] { "Id", "EstoqueId", "MaterialId", "Peso", "Quantidade" },
                values: new object[,]
                {
                    { 158, 1, 4, 8, 0 },
                    { 1166, 1, 3, 0, 4 },
                    { 2177, 1, 1, 0, 0 },
                    { 2178, 1, 1, 0, 0 },
                    { 2179, 1, 1, 0, 0 },
                    { 2180, 1, 4, 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Material",
                columns: new[] { "Id", "Descricao", "Nome", "PontuacaoPeso", "PontuacaoUnidade", "TempoDegradacao", "TipoMaterialId" },
                values: new object[] { 5, "Latinha", "Alumínio", 10, 2, 1000, 4 });

            migrationBuilder.InsertData(
                table: "Recolhimento",
                columns: new[] { "Id", "CooperativaId", "DataRecolhimento" },
                values: new object[,]
                {
                    { 9, 1, new DateTime(2025, 3, 18, 19, 4, 0, 0, DateTimeKind.Local) },
                    { 15, 1, new DateTime(2025, 3, 7, 2, 18, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "ClientePremiacao",
                columns: new[] { "Id", "ClienteId", "DataOperacao", "PremiacaoId" },
                values: new object[,]
                {
                    { 3, 7, new DateTime(2025, 1, 21, 2, 15, 38, 995, DateTimeKind.Local), 3 },
                    { 1004, 1010, new DateTime(2025, 2, 4, 17, 27, 18, 12, DateTimeKind.Local), 3 },
                    { 1005, 8, new DateTime(2025, 2, 19, 23, 37, 4, 812, DateTimeKind.Local), 3 }
                });

            migrationBuilder.InsertData(
                table: "Coleta",
                columns: new[] { "Id", "ClienteId", "DataOperacao", "PontoColetaId", "PontuacaoGanha" },
                values: new object[,]
                {
                    { 9, 6, new DateTime(2024, 11, 14, 20, 43, 0, 0, DateTimeKind.Unspecified), 2, 30 },
                    { 10, 7, new DateTime(2024, 10, 8, 20, 44, 0, 0, DateTimeKind.Unspecified), 2, 260 },
                    { 11, 5, new DateTime(2024, 12, 18, 0, 18, 0, 0, DateTimeKind.Unspecified), 1, 1000 },
                    { 13, 7, new DateTime(2025, 1, 9, 2, 16, 0, 0, DateTimeKind.Unspecified), 1, 75 },
                    { 14, 9, new DateTime(2025, 1, 22, 14, 54, 0, 0, DateTimeKind.Unspecified), 1, 0 },
                    { 1014, 1010, new DateTime(2025, 2, 4, 17, 25, 0, 0, DateTimeKind.Unspecified), 2, 120 },
                    { 1015, 1010, new DateTime(2025, 2, 4, 17, 26, 0, 0, DateTimeKind.Unspecified), 2, 200 },
                    { 1016, 1010, new DateTime(2025, 2, 3, 17, 51, 0, 0, DateTimeKind.Unspecified), 1, 6 },
                    { 1018, 7, new DateTime(2023, 7, 7, 22, 2, 0, 0, DateTimeKind.Unspecified), 1, 100 },
                    { 1019, 8, new DateTime(2025, 2, 19, 23, 36, 0, 0, DateTimeKind.Unspecified), 1, 200 },
                    { 2090, 7, new DateTime(2025, 3, 13, 3, 40, 0, 0, DateTimeKind.Unspecified), 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "EstoqueMaterial",
                columns: new[] { "Id", "EstoqueId", "MaterialId", "Peso", "Quantidade" },
                values: new object[,]
                {
                    { 159, 1007, 4, 2, 0 },
                    { 163, 1, 5, 6, 0 },
                    { 164, 1007, 5, 2, 0 },
                    { 171, 1007, 3, 0, 0 },
                    { 172, 1008, 3, 0, 0 },
                    { 1165, 1, 5, 0, 0 },
                    { 1167, 1007, 3, 0, 2 },
                    { 1168, 1007, 1, 0, 1 },
                    { 1169, 1008, 1, 0, 2 },
                    { 2163, 2, 5, 0, 0 },
                    { 2164, 1007, 1, 0, 0 },
                    { 2165, 1007, 1, 0, 0 },
                    { 2166, 1007, 1, 0, 0 },
                    { 2167, 1007, 1, 0, 0 },
                    { 2168, 1007, 3, 0, 0 },
                    { 2169, 1007, 1, 0, 0 },
                    { 2170, 1007, 3, 0, 0 },
                    { 2171, 1007, 3, 0, 0 },
                    { 2172, 1008, 3, 0, 0 },
                    { 2173, 1007, 3, 0, 0 },
                    { 2174, 1007, 1, 0, 0 },
                    { 2175, 1007, 1, 0, 0 },
                    { 2176, 1007, 4, 2, 0 },
                    { 2181, 1007, 3, 0, 0 },
                    { 2182, 1008, 3, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Material_Coleta",
                columns: new[] { "Id", "ColetaId", "MaterialId", "Peso", "Quantidade" },
                values: new object[,]
                {
                    { 2, 3, 1, 0, 2 },
                    { 3, 3, 4, 2, 0 },
                    { 4, 4, 4, 0, 2 },
                    { 5, 5, 3, 0, 2 },
                    { 6, 6, 3, 10, 0 },
                    { 7, 7, 5, 10, 0 },
                    { 8, 7, 3, 0, 5 },
                    { 9, 8, 1, 10, 0 },
                    { 14, 12, 4, 10, 0 },
                    { 1020, 1017, 3, 5, 0 },
                    { 2114, 2085, 4, 0, 12 },
                    { 3119, 3090, 5, 0, 2 },
                    { 3120, 3091, 3, 6, 0 },
                    { 3121, 3092, 1, 6, 0 },
                    { 4133, 4103, 4, 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Recolhimento",
                columns: new[] { "Id", "CooperativaId", "DataRecolhimento" },
                values: new object[,]
                {
                    { 8, 2, new DateTime(2025, 3, 25, 19, 4, 0, 0, DateTimeKind.Local) },
                    { 13, 2, new DateTime(2025, 3, 5, 19, 42, 0, 0, DateTimeKind.Local) },
                    { 14, 2, new DateTime(2025, 3, 5, 1, 54, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Material_Coleta",
                columns: new[] { "Id", "ColetaId", "MaterialId", "Peso", "Quantidade" },
                values: new object[,]
                {
                    { 10, 9, 4, 0, 3 },
                    { 11, 10, 3, 0, 20 },
                    { 12, 10, 1, 10, 0 },
                    { 13, 11, 1, 50, 0 },
                    { 15, 13, 3, 5, 0 },
                    { 16, 14, 1, 20, 0 },
                    { 1016, 1014, 2, 10, 0 },
                    { 1017, 1014, 4, 0, 2 },
                    { 1018, 1015, 1, 10, 0 },
                    { 1019, 1016, 3, 0, 2 },
                    { 1021, 1018, 4, 0, 10 },
                    { 1022, 1019, 2, 20, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecolhimentoEstoqueMaterial",
                columns: new[] { "Id", "EstoqueMaterialId", "Peso", "Quantidade", "RecolhimentoId" },
                values: new object[,]
                {
                    { 5, 1165, 0, 1, 8 },
                    { 6, 1165, 0, 1, 9 },
                    { 9, 1169, 1, 0, 13 },
                    { 1002, 1169, 2, 0, 14 },
                    { 1003, 2163, 0, 2, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TipoMaterial_Nome",
                table: "TipoMaterial",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Premiacao_Nome",
                table: "Premiacao",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PontoColeta_Nome",
                table: "PontoColeta",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Material_Nome",
                table: "Material",
                column: "Nome",
                unique: true);

            migrationBuilder.AddCheckConstraint(
                name: "CHK_Estoque_Capacidade",
                table: "Estoque",
                sql: "PesoArmazenado + QuantidadeArmazenada <= Capacidade");

            migrationBuilder.AddCheckConstraint(
                name: "CHK_Estoque_Capacidade_NaoNegativa",
                table: "Estoque",
                sql: "Capacidade >= 0");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Rua_Numero_Bairro_Cep",
                table: "Endereco",
                columns: new[] { "Rua", "Numero", "Bairro", "Cep" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cooperativa_CNPJ",
                table: "Cooperativa",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cooperativa_Email",
                table: "Cooperativa",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CNPJ",
                table: "Cliente",
                column: "CNPJ",
                unique: true,
                filter: "[CNPJ] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CPF",
                table: "Cliente",
                column: "CPF",
                unique: true,
                filter: "[CPF] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Email",
                table: "Cliente",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TipoMaterial_Nome",
                table: "TipoMaterial");

            migrationBuilder.DropIndex(
                name: "IX_Premiacao_Nome",
                table: "Premiacao");

            migrationBuilder.DropIndex(
                name: "IX_PontoColeta_Nome",
                table: "PontoColeta");

            migrationBuilder.DropIndex(
                name: "IX_Material_Nome",
                table: "Material");

            migrationBuilder.DropCheckConstraint(
                name: "CHK_Estoque_Capacidade",
                table: "Estoque");

            migrationBuilder.DropCheckConstraint(
                name: "CHK_Estoque_Capacidade_NaoNegativa",
                table: "Estoque");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_Rua_Numero_Bairro_Cep",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Cooperativa_CNPJ",
                table: "Cooperativa");

            migrationBuilder.DropIndex(
                name: "IX_Cooperativa_Email",
                table: "Cooperativa");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_CNPJ",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_CPF",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_Email",
                table: "Cliente");

            migrationBuilder.DeleteData(
                table: "ClientePremiacao",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientePremiacao",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClientePremiacao",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "ClientePremiacao",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2091);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2092);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 4105);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2164);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2165);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2166);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2167);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2168);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2169);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2170);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2171);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2172);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2173);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2174);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2175);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2176);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2177);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2178);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2179);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2180);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2181);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2182);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 2114);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 3119);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 3120);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 3121);

            migrationBuilder.DeleteData(
                table: "Material_Coleta",
                keyColumn: "Id",
                keyValue: 4133);

            migrationBuilder.DeleteData(
                table: "RecolhimentoEstoqueMaterial",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecolhimentoEstoqueMaterial",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RecolhimentoEstoqueMaterial",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RecolhimentoEstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "RecolhimentoEstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2085);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 3090);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 3091);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 3092);

            migrationBuilder.DeleteData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 4103);

            migrationBuilder.DeleteData(
                table: "Estoque",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "EstoqueMaterial",
                keyColumn: "Id",
                keyValue: 2163);

            migrationBuilder.DeleteData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Recolhimento",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Cooperativa",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Estoque",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TipoMaterial",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "TipoMaterial",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "TipoMaterial",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "PontoColetaId",
                table: "Recolhimento",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Premiacao",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Premiacao",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "PontoColeta",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "TempoDegradacao",
                table: "Material",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Material",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Material",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(9)",
                oldMaxLength: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cooperativa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cooperativa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Cooperativa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Coleta",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "PontuacaoTotal",
                table: "Cliente",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(18)",
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "RecolhimentoMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    RecolhimentoId = table.Column<int>(type: "int", nullable: false),
                    PesoTotal = table.Column<int>(type: "int", nullable: false),
                    QuantidadeTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecolhimentoMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecolhimentoMaterial_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecolhimentoMaterial_Recolhimento_RecolhimentoId",
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
                columns: new[] { "DataCadastro", "PontuacaoTotal" },
                values: new object[] { new DateTime(2025, 3, 24, 16, 50, 54, 765, DateTimeKind.Local).AddTicks(4639), 15 });

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

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "CNPJ", "CPF", "DataCadastro", "Email", "Nome", "PontuacaoTotal", "Telefone" },
                values: new object[] { 4, "54.594.954/9549-89", null, new DateTime(2025, 3, 24, 16, 50, 54, 765, DateTimeKind.Local).AddTicks(4654), "manoel@padaria.com", "Padaria Manoel", 0, "(31) 98371-8402" });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Ativo", "DataOperacao" },
                values: new object[] { false, new DateTime(2025, 3, 24, 16, 50, 54, 765, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.InsertData(
                table: "Coleta",
                columns: new[] { "Id", "Ativo", "ClienteId", "DataOperacao", "PontoColetaId", "PontuacaoGanha" },
                values: new object[] { 2, false, 1, new DateTime(2025, 3, 24, 16, 50, 54, 765, DateTimeKind.Local).AddTicks(4856), 2, 5 });

            migrationBuilder.UpdateData(
                table: "Cooperativa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CNPJ", "Email" },
                values: new object[] { "00.000.000/0000-00", "" });

            migrationBuilder.UpdateData(
                table: "Estoque",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacidade", "PesoArmazenado", "QuantidadeArmazenada" },
                values: new object[] { 10, 0, 0 });

            migrationBuilder.InsertData(
                table: "Recolhimento",
                columns: new[] { "Id", "CooperativaId", "DataRecolhimento", "PontoColetaId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 11, 21, 4, 23, 6, 153, DateTimeKind.Local), null },
                    { 2, 1, new DateTime(2025, 2, 21, 6, 23, 6, 153, DateTimeKind.Local), null }
                });

            migrationBuilder.InsertData(
                table: "RecolhimentoMaterial",
                columns: new[] { "Id", "MaterialId", "PesoTotal", "QuantidadeTotal", "RecolhimentoId" },
                values: new object[,]
                {
                    { 1, 1, 21, 0, 1 },
                    { 2, 2, 0, 10, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recolhimento_PontoColetaId",
                table: "Recolhimento",
                column: "PontoColetaId");

            migrationBuilder.CreateIndex(
                name: "IX_RecolhimentoMaterial_MaterialId",
                table: "RecolhimentoMaterial",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_RecolhimentoMaterial_RecolhimentoId",
                table: "RecolhimentoMaterial",
                column: "RecolhimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recolhimento_PontoColeta_PontoColetaId",
                table: "Recolhimento",
                column: "PontoColetaId",
                principalTable: "PontoColeta",
                principalColumn: "Id");
        }
    }
}
