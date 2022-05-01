using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Payment.Test.Tuya.BL.ProductsBL;
using Payment.Test.Tuya.Models;
using Serilog;

namespace Payment.Test.Tuya.API.Controllers
{
   
    [Route("api/products")]
    public class ProductsController : Controller
    {

        private readonly IProductsServiceBL _productsServiceBl;


        public ProductsController(IProductsServiceBL productsServiceBL)
        {
            _productsServiceBl = productsServiceBL;
        }

        /// <summary>
        /// Get Products
        /// </summary>
        /// <returns>Products</returns>
        [HttpGet]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<Products>> Get() =>
            _productsServiceBl.Get();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] Products product)
        {
            Log.Information("Creating new product", product);
            var productCreated = _productsServiceBl.Create(product);
            return CreatedAtAction(nameof(Get), new { id = productCreated.ProductId });

        }
    }
}
