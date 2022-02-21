using Microsoft.EntityFrameworkCore;
using Rookie.Ecom.DataAccessor.Data;
using Rookie.Ecom.DataAccessor.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly EcomDbContext _dbContext;

        public GenericRepository(EcomDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public Task GetByIdAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
