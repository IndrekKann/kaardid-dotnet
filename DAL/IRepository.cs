using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Guid id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T?> Delete(Guid id);
    }
}