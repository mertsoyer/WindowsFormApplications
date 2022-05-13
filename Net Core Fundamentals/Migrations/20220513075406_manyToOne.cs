using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Net_Core_Fundamentals.Migrations
{
    public partial class manyToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "product_name");

            migrationBuilder.AlterColumn<string>(
                name: "product_name",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValueSql: " 'ürün bilgisi girilmemiş' ",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getDate()");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Number);
                });

            migrationBuilder.CreateTable(
                name: "SaleHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleHistories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_product_name",
                table: "Products",
                column: "product_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SaleHistories_ProductId",
                table: "SaleHistories",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "SaleHistories");

            migrationBuilder.DropIndex(
                name: "IX_Products_product_name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "product_name",
                table: "Products",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValueSql: " 'ürün bilgisi girilmemiş' ");
        }
    }
}
