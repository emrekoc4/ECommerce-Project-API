using AutoMapper;
using ProjectECommerce.Core.DTOs;
using ProjectECommerce.Core.Models;

namespace ProjectECommerce.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductDetailDto>().ReverseMap();
            CreateMap<Order, CreateOrderRequestDto>().ReverseMap();
            CreateMap<OrderDetail, CreateOrderRequestDto>().ReverseMap();
        }
    }
}
