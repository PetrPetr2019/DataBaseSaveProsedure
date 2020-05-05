using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerCompany.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    LaptopID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Speed = table.Column<int>(nullable: false),
                    Ram = table.Column<int>(nullable: false),
                    Hd = table.Column<int>(nullable: false),
                    Screen = table.Column<float>(nullable: false),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.LaptopID);
                });

            migrationBuilder.CreateTable(
                name: "Pcs",
                columns: table => new
                {
                    PcID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Speed = table.Column<int>(nullable: false),
                    Ram = table.Column<int>(nullable: false),
                    Hd = table.Column<int>(nullable: false),
                    CD = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pcs", x => x.PcID);
                });

            migrationBuilder.CreateTable(
                name: "Printers",
                columns: table => new
                {
                    PrinterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printers", x => x.PrinterID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Market = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    LaptopID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Laptops_LaptopID",
                        column: x => x.LaptopID,
                        principalTable: "Laptops",
                        principalColumn: "LaptopID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_LaptopID",
                table: "Products",
                column: "LaptopID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pcs");

            migrationBuilder.DropTable(
                name: "Printers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Laptops");
        }
    }
}
