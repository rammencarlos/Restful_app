using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Models
{
    public class ProductModel : BaseModel
    {
        private string _sku;
        public string Sku
        {
            get { return _sku; }
            set { _sku = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

    }
}
