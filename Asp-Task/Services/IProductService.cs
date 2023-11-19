using Asp_Task.Entities;

namespace Asp_Task.Services
{
    public interface IProductService
    {
        List<Product> GetAllProductByKey(string key = "");
        void DeleteProduct(Product product);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
    }
}
