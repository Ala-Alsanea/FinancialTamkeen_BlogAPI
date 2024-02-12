using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FinancialTamkeen_BlogAPI.Dto;
using FinancialTamkeen_BlogAPI.Repositories.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinancialTamkeen_BlogAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserAuthenticationRepository userAuthentication;

        public UserController( IMapper mapper,IUserAuthenticationRepository userAuthentication) 
        {
            this.userAuthentication = userAuthentication;
        }

        [HttpPost("signup")]
        // [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationDto userRegistration)
        {

            var userResult = await this.userAuthentication.RegisterUserAsync(userRegistration);
            return !userResult.Succeeded ? new BadRequestObjectResult(userResult) : StatusCode(201);
        }

        [HttpPost("login")]
        // [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Authenticate([FromBody] UserLoginDto user)
        {
            return !await this.userAuthentication.ValidateUserAsync(user)
                ? Unauthorized()
                : Ok(new { Token = await this.userAuthentication.CreateTokenAsync() });
        }
    }
}