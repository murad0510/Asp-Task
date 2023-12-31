﻿using Asp_Task.Entities;
using Asp_Task.Repositories;

namespace Asp_Task.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetAllProductByKey(string key = "")
        {
            var data = _repository.GetAllProducts();
            if (key != "")
            {
                return data;
            }
            return data;
        }

        public void DeleteProduct(Product product)
        {
            _repository.DeleteProduct(product);
        }

        public void AddProduct(Product product)
        {
            _repository.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            _repository.UpdateProduct(product);
        }
    }
}
