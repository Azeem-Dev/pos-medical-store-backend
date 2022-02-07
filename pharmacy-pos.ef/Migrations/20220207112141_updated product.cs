using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pharmacy_pos.ef.Migrations
{
    public partial class updatedproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Batch",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExpiryDate",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name_Exp",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Batch",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Name_Exp",
                table: "Product");
        }
    }
}
