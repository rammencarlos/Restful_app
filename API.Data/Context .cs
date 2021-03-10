using API.Domain.Entities;
using System;
using System.Collections.Generic;

namespace API.Data
{
    public class Context 
    {
        //[ThreadStatic]
        private static Context _instance = null;

        /// <summary>
        /// Solo con fines de ejemplo claro...
        /// </summary>
        public List<ProductEntity> _products { get; set; }

        public Context()
        {
            _products = new List<ProductEntity>();

            _products.Add(new ProductEntity
            {
                Id = Guid.NewGuid(),
                SKU = "Test-002",
                Name = "Lapiz rojo",
                Description = "Lapiz punta fina color rojo",
                createAt = DateTime.Now
            });

            _products.Add(new ProductEntity
            {
                Id = Guid.NewGuid(),
                SKU = "Test-001",
                Name = "Libreta azul",
                Description = "Libreta con portada dura color azul",
                createAt = DateTime.Now
            });

            _products.Add(new ProductEntity
            {
                Id = Guid.NewGuid(),
                SKU = "Test-003",
                Name = "Sacapuntas",
                Description = "Sacapuntas de metal",
                createAt = DateTime.Now
            });
        }

        public static Context Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Context();
                }
                return _instance;
            }
        }

        
    }
}
