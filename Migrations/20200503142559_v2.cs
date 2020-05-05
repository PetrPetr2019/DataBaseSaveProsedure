using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerCompany.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Laptops_LaptopID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_LaptopID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LaptopID",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LaptopID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_LaptopID",
                table: "Products",
                column: "LaptopID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Laptops_LaptopID",
                table: "Products",
                column: "LaptopID",
                principalTable: "Laptops",
                principalColumn: "LaptopID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
