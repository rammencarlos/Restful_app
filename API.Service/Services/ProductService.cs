using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Domain.DTOs.Product;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Domain.Interfaces.Services.Product;
using API.Domain.Models;
using API.Domain.Repository;
using AutoMapper;

namespace API.Service.Services
{
    /// <summary>
    /// Nuestra logica de negocio
    /// </summary>

    public class ProductService : IProductService
    {
        private IProductRepository _repository;
        private readonly IMapper _mapper;


        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public bool Delete(Guid id)
        {
            return  _repository.Delete(id);
        }

        public ProductDTO Get(Guid id)
        {
            var entity =  _repository.Get(id);
            return _mapper.Map<ProductDTO>(entity) ?? new ProductDTO();
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            var listEntity =  _repository.GetAll();
            return _mapper.Map<IEnumerable<ProductDTO>>(listEntity);
        }

        public ProductDTOCreateResult Post(ProductDTOCreate product)
        {
            //Bussines
            var model = _mapper.Map<ProductModel>(product);

            var entity = _mapper.Map<ProductEntity>(model);
            var result =  _repository.Post(entity);

            return _mapper.Map<ProductDTOCreateResult>(result);
        }

        public ProductDTOUpdateResult Put(ProductDTOUpdate product)
        {
            var model = _mapper.Map<ProductModel>(product);
            var entity = _mapper.Map<ProductEntity>(model);
            var result =  _repository.Put(entity);

            return _mapper.Map<ProductDTOUpdateResult>(result);
        }
    }
}
