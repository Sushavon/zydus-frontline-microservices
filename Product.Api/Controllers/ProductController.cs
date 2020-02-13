using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Product.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {

            return GetDummyProducts();
        }

        public IEnumerable<Product> GetDummyProducts()
        {
            var products = new List<Product>() {
                new Product
                {
                    Id = 1,
                    Name = "Paracetamol",
                    Price = 1.00
                },
                new Product{
                    Id = 2,
                    Name = "Calpol",
                    Price = 1.00
                }
            };
            return products;
        }
    }
}
