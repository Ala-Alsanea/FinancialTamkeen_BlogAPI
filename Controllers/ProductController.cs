using PostApi.Domain.Services;
using PostApi.Presentation.Dtos;
using Microsoft.AspNetCore.Mvc;
using PostApi.Infrastructure.ErrorHandling;
using Microsoft.AspNetCore.RateLimiting;
using PostApi.Domain.Filters;

namespace FinancialTamkeen_BlogAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        public ProductController()
        {
        }

        [HttpGet]
        public ActionResult ListAllProducts()
        {
            // hundel get all 
        }

        [HttpGet("{id}")]
        public ActionResult SingleProduct(int id)
        {
            // hundel get SingleProduct 
        }

        [HttpPost("create")]
        public ActionResult CreateProduct([FromBody] CategoryCreateDto dto)
        {
            // hundel Create 
        }

        [HttpPut]
        [Route("{id}/update")]
        public ActionResult UpdateProduct(int id, [FromBody] CategoryUpdateDto dto)
        {
            // hundel Update 
        }


    }
}