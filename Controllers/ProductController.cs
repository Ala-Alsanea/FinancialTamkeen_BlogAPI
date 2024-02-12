using FinancialTamkeen_BlogAPI.interfaces.Repositories;
using FinancialTamkeen_BlogAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FinancialTamkeen_BlogAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet("all")]
        public ActionResult ListAllProducts()
        {
            if (ModelState.IsValid)
                return BadRequest(ModelState);

            var Products = this.productRepository.All();

            if(Products ==null)
                return NotFound("no pruducts storted");


            return Ok(Products);
        }

        // [HttpGet("{id}")]
        // public ActionResult SingleProduct(int id)
        // {
        //     // hundel get SingleProduct 
        // }

        // [HttpPost("create")]
        // public ActionResult CreateProduct([FromBody] CategoryCreateDto dto)
        // {
        //     // hundel Create 
        // }

        // [HttpPut]
        // [Route("{id}/update")]
        // public ActionResult UpdateProduct(int id, [FromBody] CategoryUpdateDto dto)
        // {
        //     // hundel Update 
        // }


    }
}