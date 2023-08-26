using Infoshare.Basics.Classes.Data;

namespace Infoshare.Basics.Classes.Repositories
{
    public class ProductRepository
    {
        public ProductRepository()
        {
        }

        public Product Get()
        {
            Product product = new Product();

            product.Id = 1;
            product.Name = "Smartphone";
            product.Price = 1199.99m;

            return product;
        }

        public void Update(Product product)
        {
            product.Name = $"{product.Name} (edited)";
        }

        public static string ClassName()
        {
            return "ProductRepository";
        }
    }
}