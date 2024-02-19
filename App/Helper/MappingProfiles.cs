using AutoMapper;
using FinancialTamkeen_BlogAPI.Domain.Models;
using FinancialTamkeen_BlogAPI.Dto;

namespace PokemonReviewApp.App.Helper
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