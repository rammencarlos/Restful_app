using AutoMapper;
using API.Domain.DTOs.Product;
using API.Domain.Entities;

namespace API.CrossCutting.Mappings
{
    public class EntityToDTOProfile : Profile
    {
        public EntityToDTOProfile()
        {
            CreateMap<ProductDTO, ProductEntity>()
              .ReverseMap();
            CreateMap<ProductDTOCreateResult, ProductEntity>()
                  .ReverseMap();
            CreateMap<ProductDTOUpdateResult, ProductEntity>()
                  .ReverseMap();
        }
    }
}
