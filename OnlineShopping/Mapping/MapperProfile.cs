using AutoMapper;
using OnlineShopping.Models.DTO.Product;

namespace OnlineShopping.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product,ProductAllDto>().ReverseMap();
        }
    }
}
