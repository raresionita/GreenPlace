using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenPlace.Models
{
    public class MockProductRepository : IProductRepository
    {
        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product{ProductId=1,Name="Pizza Pollo",Price=19.5M,ShortDescription="test",LongDescription="test"},
                new Product{ProductId=2,Name="Pizza Capriciosa",Price=20M,ShortDescription="test",LongDescription="test"},
                new Product{ProductId=3,Name="Pizza Diavola",Price=35M,ShortDescription="test",LongDescription="test"},
                new Product{ProductId=4,Name="Burger Beef",Price=24M,ShortDescription="test",LongDescription="test"}
            };

        public IEnumerable<Product> ProductsOfTheWeek { get; }

        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
