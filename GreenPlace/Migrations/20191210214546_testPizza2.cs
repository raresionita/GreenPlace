using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenPlace.Migrations
{
    public partial class testPizza2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "http://www.pizza-ok.ro/wp-content/uploads/2016/04/4stagioni2.jpg", "http://www.pizza-ok.ro/wp-content/uploads/2016/04/4stagioni2.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~/Images/CheesePizza.jpg", "~/Images/CheesePizza.jpg" });
        }
    }
}
