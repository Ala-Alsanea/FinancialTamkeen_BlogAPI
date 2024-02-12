using AutoMapper;
using FinancialTamkeen_BlogAPI.Dto;
using FinancialTamkeen_BlogAPI.Models;

namespace PokemonReviewApp.Helper
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