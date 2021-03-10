using API.Domain.DTOs.Product;
using API.Domain.Entities;
using API.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace API.Domain.Repository
{

    public interface IProductRepository 
    {
        /// <summary>
        /////Preparado para extender funcionalidad
        /// </summary>
        ProductEntity Get(Guid id);
        IEnumerable<ProductEntity> GetAll();
        ProductEntity Post(ProductEntity Product);
        ProductEntity Put(ProductEntity Product);
        bool Delete(Guid id);
    }
}
