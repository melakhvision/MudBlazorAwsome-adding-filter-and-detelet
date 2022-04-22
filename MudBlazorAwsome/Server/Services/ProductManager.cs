using Microsoft.EntityFrameworkCore;
using MudBlazorAwsome.Server.Interfaces;
using MudBlazorAwsome.Server.Models;
using MudBlazorAwsome.Shared.Models;

namespace MudBlazorAwsome.Server.Services
{
    public class ProductManager : IProduct
    {
        readonly DatabaseContext _dbContext = new();
        public ProductManager(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        //To Get all user details
        public List<Product> GetProductDetails()
        {
            try
            {
                return _dbContext.Products.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To Add new user record
        public void AddProduct(Product product)
        {
            try
            {
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar user
        //Get the details of a particular user
        public Product GetProductData(int id)
        {
            try
            {
                Product? product = _dbContext.Products.Find(id);
                if (product != null)
                {
                    return product;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular user

        public void UpdateProductDetails(Product product)
        {
            try
            {
                _dbContext.Entry(product).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                Product? product = _dbContext.Products.Find(id);
                if (product != null)
                {
                    _dbContext.Products.Remove(product);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
