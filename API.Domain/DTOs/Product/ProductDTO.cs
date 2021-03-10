using System;

namespace API.Domain.DTOs.Product
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string SKU { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
