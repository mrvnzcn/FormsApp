namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category { CategoryId = Guid.NewGuid(), Name = "Telefon" });
            _categories.Add(new Category { CategoryId = Guid.NewGuid(), Name = "Bilgisayar" });

            Guid PhoneCategoryId = Guid.NewGuid();
            Guid ComputerCategoryId = Guid.NewGuid();

            _products.Add(new Product { ProductId = Guid.NewGuid(), Name="Iphone 14", Price = 40000, isActive = true, Image = "1.jpg", CategoryId = PhoneCategoryId});
            _products.Add(new Product { ProductId = Guid.NewGuid(), Name="Iphone 15", Price = 50000, isActive = true, Image = "2.jpg", CategoryId = PhoneCategoryId});
            _products.Add(new Product { ProductId = Guid.NewGuid(), Name="Iphone 16", Price = 60000, isActive = true, Image = "3.jpg", CategoryId = PhoneCategoryId});
            _products.Add(new Product { ProductId = Guid.NewGuid(), Name="Iphone 17", Price = 70000, isActive = true, Image = "4.jpg", CategoryId = PhoneCategoryId});

            _products.Add(new Product { ProductId = Guid.NewGuid(), Name="MacBook Air", Price = 80000, isActive = true, Image = "5.jpg", CategoryId = ComputerCategoryId});
            _products.Add(new Product { ProductId = Guid.NewGuid(), Name="Macbook Pro", Price = 90000, isActive = true, Image = "6.jpg", CategoryId = ComputerCategoryId});
        }

        public static List<Product> Products
        {
            get 
            {
                return _products;
            }
        }

        public static List<Category> Categories
        {
            get 
            {
                return _categories;
            }
        } 
    }
}