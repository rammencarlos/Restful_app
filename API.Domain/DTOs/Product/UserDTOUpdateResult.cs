using System;

namespace API.Domain.DTOs.Product
{
    public class ProductDTOUpdateResult
    {
        public Guid Id { get; set; }
        public string SKU { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
