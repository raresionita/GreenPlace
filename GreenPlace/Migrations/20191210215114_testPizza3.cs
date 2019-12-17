using Microsoft.EntityFrameworkCore.Migrations;

namespace GreenPlace.Migrations
{
    public partial class testPizza3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "ShortDescription" },
                values: new object[] { "Quattro Stagioni Pizza", "Our famous pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://d1doqjmisr497k.cloudfront.net/-/media/mccormick-us/recipes/lawrys/g/800/grilled-greek-chicken-pizza.jpg", "https://d1doqjmisr497k.cloudfront.net/-/media/mccormick-us/recipes/lawrys/g/800/grilled-greek-chicken-pizza.jpg", "Chicken Pizza", "Our Chicken favorite" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "http://latavi.ro/wp-content/uploads/2018/03/pizza-cu-salam.jpg", "http://latavi.ro/wp-content/uploads/2018/03/pizza-cu-salam.jpg", "Pizza Diavola", "My God, so spicy!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "ShortDescription" },
                values: new object[] { "Chicken Pizza", "Our famous apple pies!" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", "Pumpkin Pie", "Our Halloween favorite" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", "Rhubarb Pie", "My God, so sweet!" });
        }
    }
}
