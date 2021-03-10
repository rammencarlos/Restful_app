using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
