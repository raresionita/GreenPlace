using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenPlace.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
        { 

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Pizza" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Burger" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Salad" });

            //seed products

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Quattro Stagioni Pizza",
                Price = 12.95M,
                ShortDescription = "Our famous pizza",
                LongDescription =
                "PIZZA QUATTRO STAGIONI is typically prepared using artichokes, tomatoes or basil, mushrooms, and ham or prosciutto, or olives. The artichokes represent spring, tomatoes or basil represent summer, mushrooms represent autumn and the ham or olives represent winter. Other ingredients may also be used. It is typically prepared using a tomato sauce and cheese. Fresh-cooked or canned artichoke hearts may be used. Some of the topping ingredients can first be dried in an oven to reduce their moisture, which prevents the pizza from being soggy when finished. Baking it on a pizza stone can also prevent sogginess. It may be finished with olive oil drizzled atop the pizza. The pizza can be sliced into wedges or by its four sections. Pizza quattro stagioni can be prepared as a vegetarian dish by substituting ham with a vegetarian option.",
                CategoryId = 1,
                ImageUrl = "http://www.pizza-ok.ro/wp-content/uploads/2016/04/4stagioni2.jpg",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "http://www.pizza-ok.ro/wp-content/uploads/2016/04/4stagioni2.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Chicken Burger",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription =
                "CHICKEN BURGER is typically prepared using artichokes, tomatoes or basil, mushrooms, and ham or prosciutto, or olives. The artichokes represent spring, tomatoes or basil represent summer, mushrooms represent autumn and the ham or olives represent winter. Other ingredients may also be used. It is typically prepared using a tomato sauce and cheese. Fresh-cooked or canned artichoke hearts may be used. Some of the topping ingredients can first be dried in an oven to reduce their moisture, which prevents the pizza from being soggy when finished. Baking it on a pizza stone can also prevent sogginess. It may be finished with olive oil drizzled atop the pizza. The pizza can be sliced into wedges or by its four sections. Pizza quattro stagioni can be prepared as a vegetarian dish by substituting ham with a vegetarian option.",
                CategoryId = 2,
                ImageUrl = "http://www.howsweeteats.com/wp-content/uploads/2011/04/bbqburgers-6.jpg",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl =
                    "http://www.howsweeteats.com/wp-content/uploads/2011/04/bbqburgers-6.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Beef Burger",
                Price = 18.95M,
                ShortDescription = "Plain beef burger. Plain pleasure.",
                LongDescription =
                "BEEF BURGER is typically prepared using artichokes, tomatoes or basil, mushrooms, and ham or prosciutto, or olives. The artichokes represent spring, tomatoes or basil represent summer, mushrooms represent autumn and the ham or olives represent winter. Other ingredients may also be used. It is typically prepared using a tomato sauce and cheese. Fresh-cooked or canned artichoke hearts may be used. Some of the topping ingredients can first be dried in an oven to reduce their moisture, which prevents the pizza from being soggy when finished. Baking it on a pizza stone can also prevent sogginess. It may be finished with olive oil drizzled atop the pizza. The pizza can be sliced into wedges or by its four sections. Pizza quattro stagioni can be prepared as a vegetarian dish by substituting ham with a vegetarian option.",
                CategoryId = 2,
                ImageUrl = "https://img1.cookinglight.timeinc.net/sites/default/files/styles/4_3_horizontal_-_900x694/public/image/2016/05/main/1605p115-mushroom-beef-burger.jpg?itok=xGgGfd2h",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://img1.cookinglight.timeinc.net/sites/default/files/styles/4_3_horizontal_-_900x694/public/image/2016/05/main/1605p115-mushroom-beef-burger.jpg?itok=xGgGfd2h",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Double Summer Burger",
                Price = 15.95M,
                ShortDescription = "A summer classic!",
                LongDescription =
                "DOUBLE SUMMER BURGER is typically prepared using artichokes, tomatoes or basil, mushrooms, and ham or prosciutto, or olives. The artichokes represent spring, tomatoes or basil represent summer, mushrooms represent autumn and the ham or olives represent winter. Other ingredients may also be used. It is typically prepared using a tomato sauce and cheese. Fresh-cooked or canned artichoke hearts may be used. Some of the topping ingredients can first be dried in an oven to reduce their moisture, which prevents the pizza from being soggy when finished. Baking it on a pizza stone can also prevent sogginess. It may be finished with olive oil drizzled atop the pizza. The pizza can be sliced into wedges or by its four sections. Pizza quattro stagioni can be prepared as a vegetarian dish by substituting ham with a vegetarian option.",
                CategoryId = 2,
                ImageUrl = "https://bdnmb.ca/wp-content/uploads/2019/09/burger-2762431_960_720.jpg",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://bdnmb.ca/wp-content/uploads/2019/09/burger-2762431_960_720.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Caesar Salad",
                Price = 13.95M,
                ShortDescription = "Happy holidays with this salad!",
                LongDescription =
                "CAESAR SALAD is typically prepared using artichokes, tomatoes or basil, mushrooms, and ham or prosciutto, or olives. The artichokes represent spring, tomatoes or basil represent summer, mushrooms represent autumn and the ham or olives represent winter. Other ingredients may also be used. It is typically prepared using a tomato sauce and cheese. Fresh-cooked or canned artichoke hearts may be used. Some of the topping ingredients can first be dried in an oven to reduce their moisture, which prevents the pizza from being soggy when finished. Baking it on a pizza stone can also prevent sogginess. It may be finished with olive oil drizzled atop the pizza. The pizza can be sliced into wedges or by its four sections. Pizza quattro stagioni can be prepared as a vegetarian dish by substituting ham with a vegetarian option.",
                CategoryId = 3,
                ImageUrl = "https://www.fifteenspatulas.com/wp-content/uploads/2011/10/Caesar-Salad-Fifteen-Spatulas-3.jpg",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://www.fifteenspatulas.com/wp-content/uploads/2011/10/Caesar-Salad-Fifteen-Spatulas-3.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Chicken Salad",
                Price = 17.95M,
                ShortDescription = "A favorite salad",
                LongDescription =
                "CHICKEN SALAD is typically prepared using artichokes, tomatoes or basil, mushrooms, and ham or prosciutto, or olives. The artichokes represent spring, tomatoes or basil represent summer, mushrooms represent autumn and the ham or olives represent winter. Other ingredients may also be used. It is typically prepared using a tomato sauce and cheese. Fresh-cooked or canned artichoke hearts may be used. Some of the topping ingredients can first be dried in an oven to reduce their moisture, which prevents the pizza from being soggy when finished. Baking it on a pizza stone can also prevent sogginess. It may be finished with olive oil drizzled atop the pizza. The pizza can be sliced into wedges or by its four sections. Pizza quattro stagioni can be prepared as a vegetarian dish by substituting ham with a vegetarian option.",
                CategoryId = 3,
                ImageUrl = "https://media4.s-nbcnews.com/j/newscms/2019_20/1437505/chinatown_chicken_salad_7db57f6a1845004c274840d39ce2b31c.today-inline-large.jpg",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://media4.s-nbcnews.com/j/newscms/2019_20/1437505/chinatown_chicken_salad_7db57f6a1845004c274840d39ce2b31c.today-inline-large.jpg",
                AllergyInformation = ""
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Chicken Pizza",
                Price = 12.95M,
                ShortDescription = "Our Chicken favorite",
                LongDescription =
                "CHICKEN PIZZA is typically prepared using artichokes, tomatoes or basil, mushrooms, and ham or prosciutto, or olives. The artichokes represent spring, tomatoes or basil represent summer, mushrooms represent autumn and the ham or olives represent winter. Other ingredients may also be used. It is typically prepared using a tomato sauce and cheese. Fresh-cooked or canned artichoke hearts may be used. Some of the topping ingredients can first be dried in an oven to reduce their moisture, which prevents the pizza from being soggy when finished. Baking it on a pizza stone can also prevent sogginess. It may be finished with olive oil drizzled atop the pizza. The pizza can be sliced into wedges or by its four sections. Pizza quattro stagioni can be prepared as a vegetarian dish by substituting ham with a vegetarian option.",
                CategoryId = 1,
                ImageUrl = "https://d1bjorv296jxfn.cloudfront.net/s3fs-public/styles/recipes_header_image/public/recipe-images/sargento/789-TuscanCKpizza.jpg?itok=hTgzOd0o",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://d1bjorv296jxfn.cloudfront.net/s3fs-public/styles/recipes_header_image/public/recipe-images/sargento/789-TuscanCKpizza.jpg?itok=hTgzOd0o",
                AllergyInformation = ""
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Pizza Diavola",
                Price = 15.95M,
                ShortDescription = "My God, so spicy!",
                LongDescription =
                "PIZZA DIAVOLA is typically prepared using artichokes, tomatoes or basil, mushrooms, and ham or prosciutto, or olives. The artichokes represent spring, tomatoes or basil represent summer, mushrooms represent autumn and the ham or olives represent winter. Other ingredients may also be used. It is typically prepared using a tomato sauce and cheese. Fresh-cooked or canned artichoke hearts may be used. Some of the topping ingredients can first be dried in an oven to reduce their moisture, which prevents the pizza from being soggy when finished. Baking it on a pizza stone can also prevent sogginess. It may be finished with olive oil drizzled atop the pizza. The pizza can be sliced into wedges or by its four sections. Pizza quattro stagioni can be prepared as a vegetarian dish by substituting ham with a vegetarian option.",
                CategoryId = 1,
                ImageUrl = "http://latavi.ro/wp-content/uploads/2018/03/pizza-cu-salam.jpg",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "http://latavi.ro/wp-content/uploads/2018/03/pizza-cu-salam.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Pizza Capriciosa",
                Price = 15.95M,
                ShortDescription = "Our delicious capriciosa pizza!",
                LongDescription =
                "PIZZA CAPRICIOSA is typically prepared using artichokes, tomatoes or basil, mushrooms, and ham or prosciutto, or olives. The artichokes represent spring, tomatoes or basil represent summer, mushrooms represent autumn and the ham or olives represent winter. Other ingredients may also be used. It is typically prepared using a tomato sauce and cheese. Fresh-cooked or canned artichoke hearts may be used. Some of the topping ingredients can first be dried in an oven to reduce their moisture, which prevents the pizza from being soggy when finished. Baking it on a pizza stone can also prevent sogginess. It may be finished with olive oil drizzled atop the pizza. The pizza can be sliced into wedges or by its four sections. Pizza quattro stagioni can be prepared as a vegetarian dish by substituting ham with a vegetarian option.",
                CategoryId = 1,
                ImageUrl = "https://www.naneti.ro/wp-content/uploads/2018/12/pizza-gourmet-capriciosa-naneti-1500x1000.jpg",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://www.naneti.ro/wp-content/uploads/2018/12/pizza-gourmet-capriciosa-naneti-1500x1000.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Cheese Pizza",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription =
                "CHEESE PIZZA is typically prepared using artichokes, tomatoes or basil, mushrooms, and ham or prosciutto, or olives. The artichokes represent spring, tomatoes or basil represent summer, mushrooms represent autumn and the ham or olives represent winter. Other ingredients may also be used. It is typically prepared using a tomato sauce and cheese. Fresh-cooked or canned artichoke hearts may be used. Some of the topping ingredients can first be dried in an oven to reduce their moisture, which prevents the pizza from being soggy when finished. Baking it on a pizza stone can also prevent sogginess. It may be finished with olive oil drizzled atop the pizza. The pizza can be sliced into wedges or by its four sections. Pizza quattro stagioni can be prepared as a vegetarian dish by substituting ham with a vegetarian option.",
                CategoryId = 1,
                ImageUrl = "https://i.ytimg.com/vi/1pVqlEBmPJU/maxresdefault.jpg",
                InStock = false,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl ="https://i.ytimg.com/vi/1pVqlEBmPJU/maxresdefault.jpg",
                AllergyInformation = ""
            });
        }
    }
}
