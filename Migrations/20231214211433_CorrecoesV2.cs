using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RenanAlmeida.Migrations
{
    public partial class CorrecoesV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVenda_TiposDePagamento_TipoDePagamentoId",
                table: "NotasDeVenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposDePagamento",
                table: "TiposDePagamento");

            migrationBuilder.RenameTable(
                name: "TiposDePagamento",
                newName: "TipoDePagamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoDePagamento",
                table: "TipoDePagamento",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVenda_TipoDePagamento_TipoDePagamentoId",
                table: "NotasDeVenda",
                column: "TipoDePagamentoId",
                principalTable: "TipoDePagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVenda_TipoDePagamento_TipoDePagamentoId",
                table: "NotasDeVenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoDePagamento",
                table: "TipoDePagamento");

            migrationBuilder.RenameTable(
                name: "TipoDePagamento",
                newName: "TiposDePagamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposDePagamento",
                table: "TiposDePagamento",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVenda_TiposDePagamento_TipoDePagamentoId",
                table: "NotasDeVenda",
                column: "TipoDePagamentoId",
                principalTable: "TiposDePagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
