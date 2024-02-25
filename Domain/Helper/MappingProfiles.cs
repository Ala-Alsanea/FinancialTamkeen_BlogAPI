using AutoMapper;
using FinancialTamkeen_BlogAPI.Domain.Models;
using FinancialTamkeen_BlogAPI.Dto;

namespace FinancialTamkeen_BlogAPI.Domain.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto,Product>();
            CreateMap<UserRegistrationDto, User>();

        }
    }
}