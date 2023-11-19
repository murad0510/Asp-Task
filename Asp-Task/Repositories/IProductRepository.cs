using Asp_Task.Entities;

namespace Asp_Task.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
