using AutoMapper;
using FinancialTamkeen_BlogAPI.Dto;
using FinancialTamkeen_BlogAPI.interfaces.Repositories;
using FinancialTamkeen_BlogAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FinancialTamkeen_BlogAPI.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;

        public ProductController(IProductRepository productRepository,IMapper mapper,IConfiguration configuration)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        [HttpGet("all")]
        public ActionResult ListAllProducts()
        {
            // return Ok(this.configuration.GetSection("Jwt")["Key"]);

            var Products = this.productRepository.All();

            if(!Products.Any())
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(Products);
        }

        [HttpGet("{id}")]
        public ActionResult SingleProduct(int id)
        {
            if (!this.productRepository.ProductExists(id))
                return NotFound();

            var category = this.productRepository.GetById(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(category);
        }

        [HttpPost("create")]
        public ActionResult CreateProduct([FromBody] ProductDto dto)
        {
            if (dto == null)
                return BadRequest(ModelState);


            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var productMap = this.mapper.Map<Product>(dto);

            if(!this.productRepository.Create(productMap))
            {
                ModelState.AddModelError("", "Something went wrong while savin");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");        }

        [HttpPut("{id}/update")]
        public ActionResult UpdateProduct(int id, [FromBody] ProductDto dto)
        {
            if (dto == null)
                return BadRequest(ModelState);

            if (!this.productRepository.ProductExists(id))
                return BadRequest();

            if (!this.productRepository.ProductExists(id))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var productMap = this.mapper.Map<Product>(dto);
            productMap.ProductId = id;

            if (!this.productRepository.Update(productMap))
            {
                ModelState.AddModelError("", "Something went wrong updating category");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }


    }
}