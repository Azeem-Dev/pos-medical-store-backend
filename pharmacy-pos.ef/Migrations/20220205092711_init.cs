using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pharmacy_pos.ef.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackQuantity = table.Column<int>(type: "int", nullable: false),
                    PackCostPrice = table.Column<double>(type: "float", nullable: false),
                    PackRetailPrice = table.Column<double>(type: "float", nullable: false),
                    RackNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarCodeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarCodePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufactorer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeId",
                table: "Product",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductType");
        }
    }
}
