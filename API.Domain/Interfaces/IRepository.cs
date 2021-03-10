using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Domain.Entities;

namespace API.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Me hubiera gustado usar un repositorio generico pero... lo dejo aqui como ejemplo
        /// </summary>

        T Insert(T item);
        T Update(T item);
        bool Delete(Guid id);
        T Select(Guid id);
        IEnumerable<T> Select();
    }
}
