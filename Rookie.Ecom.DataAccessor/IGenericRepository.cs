using Rookie.Ecom.DataAccessor.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task GetByIdAsync(Guid? id);
        Task UpdateAsync(Category category);
    }
}
