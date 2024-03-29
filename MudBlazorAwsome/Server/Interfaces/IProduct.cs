﻿using MudBlazorAwsome.Shared.Models;

namespace MudBlazorAwsome.Server.Interfaces
{
    public interface IProduct
    {
        public List<Product> GetProductDetails();
        public void AddProduct(Product product);
        public void UpdateProductDetails(Product product);
        public Product GetProductData(int id);
        public void DeleteProduct(int id);
    }
}
