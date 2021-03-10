using AutoMapper;
using API.Domain.DTOs.Product;
using API.Domain.Models;

namespace API.CrossCutting.Mappings
{
    public class DTOToModelProfile : Profile
    {

        public DTOToModelProfile()
        {
            CreateMap<ProductModel, ProductDTO>()
                .ReverseMap();

            CreateMap<ProductModel, ProductDTOCreate>()
                    .ReverseMap();

            CreateMap<ProductModel, ProductDTOUpdate>()
                    .ReverseMap();
        }
    }
}
