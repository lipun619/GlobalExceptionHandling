using GlobalExceptionHandling.Exceptions;
using GlobalExceptionHandling.Model;
using GlobalExceptionHandling.Services;
using Microsoft.AspNetCore.Mvc;
using NotImplementedException = GlobalExceptionHandling.Exceptions.NotImplementedException;

namespace GlobalExceptionHandling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private ILogger<ProductController> _logger;

        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            this.productService = productService;
            _logger = logger;
        }

        [HttpGet("ProductList")]
        public Task<IEnumerable<Product>> ProductList()
        {
            var productList = productService.GetProductList();
            return productList;
        }

        [HttpGet("GetProductById")]
        public Task<Product> GetProductById(int id)
        {
            _logger.LogInformation($"Fetch product with ID: {id} from the database");
            var product = productService.GetProductById(id);
            if (product.Result == null)
            {
                throw new NotFoundException($"Product ID {id} not found.");
            }
            _logger.LogInformation($"Returning product with ID: {product.Result.ProductId}.");
            return product;
        }

        [HttpPost("Addproduct")]
        public Task<Product> AddProduct(Product product)
        {
            return productService.AddProduct(product);
        }
        [HttpPut("Updateproduct")]
        public Task<Product> UpdateProduct(Product product)
        {
            return productService.UpdateProduct(product);
        }
        [HttpDelete("Deleteproduct")]
        public Task<bool> DeleteProduct(int Id)
        {
            return productService.DeleteProduct(Id);
        }
        [HttpGet("Filterproduct")]
        public Task<List<Product>> FilterProduct(int Id)
        {
            throw new NotImplementedException("Not Implemented Exception!");
        }
    }
}
