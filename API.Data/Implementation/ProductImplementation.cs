using API.Domain.Entities;
using API.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using API.Domain.DTOs.Product;

namespace API.Data.Implementation
{
    public class ProductImplementation : IProductRepository
    {
        private List<ProductEntity> _dataSet;
        public ProductImplementation()
        {
            var context = Context.Instance;
            _dataSet = context._products;
        }

        public bool Delete(Guid id)
        {
            try
            {
                var result = _dataSet.SingleOrDefault(p => p.Id.Equals(id));
                if (result == null)
                    return false;

                _dataSet.Remove(result);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProductEntity Get(Guid id)
        {
            try
            {
                return _dataSet.SingleOrDefault(p => p.Id.Equals(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<ProductEntity> GetAll()
        {
            try
            {
                return _dataSet.ToList<ProductEntity>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProductEntity Post(ProductEntity item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                    item.Id = Guid.NewGuid();

                item.createAt = DateTime.Now;

                _dataSet.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }

        public ProductEntity Put(ProductEntity item)
        {
            try
            {
                var result = _dataSet.SingleOrDefault(p => p.Id.Equals(item.Id));
                if (result == null)
                    return null;

                item.UpdateAt = DateTime.Now;
                item.createAt = result.createAt;

                int index = _dataSet.FindIndex(item => item.Id == result.Id);
                _dataSet[index] = item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }






    }
}
