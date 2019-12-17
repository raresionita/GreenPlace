using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenPlace.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Pizza",Description="All-Pizza"},
                new Category{CategoryId=2,CategoryName="Burger",Description="All-Burger"},
                new Category{CategoryId=3,CategoryName="Salad",Description="All-Salad"}
            };
    }
}
