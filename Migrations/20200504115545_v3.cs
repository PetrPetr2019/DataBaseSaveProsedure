using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerCompany.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Hd",
                table: "Pcs",
                newName: "hd");

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Pcs",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "hd",
                table: "Pcs",
                newName: "Hd");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Pcs",
                type: "float",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
