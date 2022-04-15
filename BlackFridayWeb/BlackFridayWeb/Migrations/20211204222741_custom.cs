using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackFridayWeb.Migrations
{
    public partial class custom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_name",
                table: "Products",
                column: "name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_name",
                table: "Products");
        }
    }
}
