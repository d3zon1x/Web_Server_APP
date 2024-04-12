using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Web_Server.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params string[] includeProperties);
        Task<TEntity> GetByIDAsync(object id);
        Task InsertAsync(TEntity entity);
        Task DeleteAsync(object id);
        Task DeleteAsync(TEntity entityToDelete);
        Task Update(TEntity entityToUpdate);
        Task UpdateAsync(TEntity entityToUpdate);
        Task SaveAsync();
        Task Attach(TEntity entity);
    }
}
