using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductCSAPI.Models;


namespace ProductCSAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Products> _products =new List<Products>();
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IEnumerable<Products> products, ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("defaultproducts")]
        public IEnumerable<Products> GetProducts()
        {

            var rng = new Random();
            var range = rng.Next();
            _logger.LogInformation(21, "", range);

            System.Diagnostics.Debug.WriteLine(range);
            _products.Add(new Products
            {
                prodID = range,
                prodName = "Name" + range.ToString(),
                prodCode = "LKC001" + range.ToString(),
                prodDescription = "modem router" + range.ToString()

            });

            return _products;
          

        }

        [HttpPost("addproducts")]
        public  ActionResult<List<Products>>  SetProducts(Products prod)
        {
           _products.Add(prod);
           return _products;
        }

        [HttpGet("products/{id}")]
        public ActionResult<Products> GetSingleProduct(int id)
        {
            var ps = _products.Find(x=>x.prodID==id);
            return ps;
        }

        [HttpDelete("products/{id}")]
        public  ActionResult<List<Products>>  DeleteProduct(int id)
        {
            var index =_products.FindIndex(x=>x.prodID==id);
           _products.RemoveAt(index);
           //_logger.LogInformation(21,"Deleting Id {id} and index {index}",_products);
           return _products;
        }


    }
}
