using System;
using System.Collections.Generic;
using System.Net.Mime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payment.Test.Tuya.BL.ProductsBL;
using Payment.Test.Tuya.Models;


namespace Payment.Test.Tuya.API.Controllers
{

    [Route("api/products")]
    public class ProductsController : Controller
    {

        private readonly IProductsServiceBL _productsServiceBl;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="productsServiceBL"></param>
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
        /// Create Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]        
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] Products product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var productCreated = _productsServiceBl.Create(product);
                    return CreatedAtAction(nameof(Get), new { id = productCreated.ProductId });
                }
                return BadRequest();
                
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
