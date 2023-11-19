using Asp_Task.Data;
using Asp_Task.Entities;

namespace Asp_Task.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ProductDBContext _productDBContext;

        public EFProductRepository(ProductDBContext productDBContext)
        {
            _productDBContext = productDBContext;
        }

        public void AddProduct(Product product)
        {
            _productDBContext.Products.Add(product);
            _productDBContext.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _productDBContext.Remove(product);
            _productDBContext.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            //var products = _productDBContext.Products.ToList();
            var products = _productDBContext.Products.ToList();
            return products;
        }

        public void UpdateProduct(Product newProduc)
        {
            var oldPoduct = GetAllProducts().Where(s => s.Id == newProduc.Id).First();
            oldPoduct.Name = newProduc.Name;
            oldPoduct.Price = newProduc.Price;
            _productDBContext.SaveChanges();
        }
    }
}
