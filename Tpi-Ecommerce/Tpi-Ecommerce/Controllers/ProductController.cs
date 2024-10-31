using Aplication.Interfaces;
using Aplication.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tpi_Ecommerce.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }
        [HttpGet("{name}")]
        public ActionResult GetByName(string name) 
        {
            var prod = _productService.GetProductByName(name);
            if (prod == null) { return NotFound("Product not Found"); }
            return Ok(prod);    
        }

        [HttpPost]
        public ActionResult AddProduct(AddProductRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.ToList());
            }
            _productService.AddProduct(request);
            return Ok();
        }
        [HttpPut]
        public ActionResult UpdateProduct(string name, UpdateProductRequest request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.ToList());
            }
            _productService.UpdateProduct(name, request);
            return NoContent();
        }
        [HttpDelete]
        public ActionResult DeleteProduct(string name)
        {
            var prodDelete = _productService.DeleteProduct(name);

            if(prodDelete == false) { return NotFound(); }

            return NoContent();
        }
    }
}
