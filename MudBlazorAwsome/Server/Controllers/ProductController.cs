using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MudBlazorAwsome.Server.Interfaces;
using MudBlazorAwsome.Shared.Models;

namespace MudBlazorAwsome.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _IProduct;
        public ProductController(IProduct iProduct)
        {
            _IProduct = iProduct;
        }
        public async Task<List<Product>> Get()
        {
            return await Task.FromResult(_IProduct.GetProductDetails());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Product product = _IProduct.GetProductData(id); 
            if (product != null)
            {
                return Ok(product);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(Product product)
        {
            _IProduct.AddProduct(product);
        }
        [HttpPut]
        public void Put(Product product)
        {
            _IProduct.UpdateProductDetails(product);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _IProduct.DeleteProduct(id);
            return Ok();
        }
    }
}
