using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancialTamkeen_BlogAPI.Dto;
using FinancialTamkeen_BlogAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace FinancialTamkeen_BlogAPI.Repositories.interfaces
{
    public interface IUserAuthenticationRepository
    {
        Task<IdentityResult> RegisterUserAsync(UserRegistrationDto userForRegistration);
        Task<bool> ValidateUserAsync(UserLoginDto loginDto);
        Task<string> CreateTokenAsync();
    }
}