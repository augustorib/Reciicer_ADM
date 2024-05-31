using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class TipoMaterialReciclagem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PontuacaoMaterial_TipoMaterialId",
                table: "PontuacaoMaterial");

            migrationBuilder.AddColumn<int>(
                name: "TipoMaterialId",
                table: "Material_Reciclagem",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_PontuacaoMaterial_TipoMaterialId",
                table: "PontuacaoMaterial",
                column: "TipoMaterialId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Material_Reciclagem_TipoMaterialId",
                table: "Material_Reciclagem",
                column: "TipoMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Reciclagem_TipoMaterial_TipoMaterialId",
                table: "Material_Reciclagem",
                column: "TipoMaterialId",
                principalTable: "TipoMaterial",
                principalColumn: "Id");

            migrationBuilder.Sql(@"CREATE PROCEDURE UpdateReciclagemPontuacaoGanha
                                    @ReciclagemId INT
                                AS
                                BEGIN
                                UPDATE Reciclagem
                                SET PontuacaoGanha = (SELECT 
                                                            ISNULL(SUM(Q.PONTUACAO_RECICLAGEM),0)
                                                    FROM
                                                            (
                                                                select 
                                                                    MR.peso , MR.Quantidade , P.PontuacaoUnidade
                                                                    , CASE 
                                                                        WHEN MR.Quantidade <> 0 THEN MR.Quantidade * P.PontuacaoUnidade
                                                                        WHEN MR.Peso <> 0 THEN MR.Peso * P.PontuacaoPeso
                                                                    END
                                                                        AS 
                                                                        PONTUACAO_RECICLAGEM
                                                                from 
                                                                    Material_Reciclagem MR
                                                                    JOIN Material M on MR.MaterialId = M.id
                                                                    JOIN TipoMaterial TM ON M.id = TM.MaterialId
                                                                    JOIN PontuacaoMaterial P ON TM.Id =  P.TipoMaterialId
                                                                where
                                                                    MR.ReciclagemId = @ReciclagemId
                                                            ) Q
                                                    )

                                WHERE Reciclagem.id = @ReciclagemId
                            END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_Reciclagem_TipoMaterial_TipoMaterialId",
                table: "Material_Reciclagem");

            migrationBuilder.DropIndex(
                name: "IX_PontuacaoMaterial_TipoMaterialId",
                table: "PontuacaoMaterial");

            migrationBuilder.DropIndex(
                name: "IX_Material_Reciclagem_TipoMaterialId",
                table: "Material_Reciclagem");

            migrationBuilder.DropColumn(
                name: "TipoMaterialId",
                table: "Material_Reciclagem");

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 5, 25, 6, 53, 48, 740, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Reciclagem",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 5, 25, 6, 53, 48, 740, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.CreateIndex(
                name: "IX_PontuacaoMaterial_TipoMaterialId",
                table: "PontuacaoMaterial",
                column: "TipoMaterialId");

            migrationBuilder.Sql("DROP PROCEDURE UpdateReciclagemPontuacaoGanha");
        }
    }
}
