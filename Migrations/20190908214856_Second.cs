using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_test.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "Products",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Products",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Products",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Products",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "ArmazemData",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Armazems",
                columns: table => new
                {
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armazems", x => x.Data);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ArmazemData",
                table: "Products",
                column: "ArmazemData");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Armazems_ArmazemData",
                table: "Products",
                column: "ArmazemData",
                principalTable: "Armazems",
                principalColumn: "Data",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Armazems_ArmazemData",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Armazems");

            migrationBuilder.DropIndex(
                name: "IX_Products_ArmazemData",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ArmazemData",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Products",
                newName: "tipo");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Products",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Products",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "id");
        }
    }
}
