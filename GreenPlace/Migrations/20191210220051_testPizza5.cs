using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenPlace.Migrations
{
    public partial class testPizza5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://d1bjorv296jxfn.cloudfront.net/s3fs-public/styles/recipes_header_image/public/recipe-images/sargento/789-TuscanCKpizza.jpg?itok=hTgzOd0o", "https://d1bjorv296jxfn.cloudfront.net/s3fs-public/styles/recipes_header_image/public/recipe-images/sargento/789-TuscanCKpizza.jpg?itok=hTgzOd0o" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://d1doqjmisr497k.cloudfront.net/-/media/mccormick-us/recipes/lawrys/g/800/grilled-greek-chicken-pizza.jpg", "https://d1doqjmisr497k.cloudfront.net/-/media/mccormick-us/recipes/lawrys/g/800/grilled-greek-chicken-pizza.jpg" });
        }
    }
}
