using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Domain.DTOs.Product;

namespace API.Domain.Interfaces.Services.Product
{
    public interface IProductService
    {
        ProductDTO Get(Guid id);
        IEnumerable<ProductDTO> GetAll();
        ProductDTOCreateResult Post(ProductDTOCreate Product);
        ProductDTOUpdateResult Put(ProductDTOUpdate Product);
        bool Delete(Guid id);
    }
}
