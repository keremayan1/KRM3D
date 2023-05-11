using System.Linq.Expressions;
using Core.Persistance.Paging;
using Microsoft.EntityFrameworkCore.Query;
using MongoDB.Driver.Linq;

namespace Core.Persistance.Repositories
{
    public interface IAsyncRepository<T> : IQuery<T> where T : IEntity
    {
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate);
        Task<T?> GetAsync2(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null);
        Task<IPaginate<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                        Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                        int index = 0, int size = 10, bool enableTracking = true,
                                        CancellationToken cancellationToken = default);
        Task<IPaginate<T>> GetListByDynamicAsync(Dynamic.Dynamic dynamic,
                                                Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                                int index = 0, int size = 10, bool enableTracking = true,
                                                CancellationToken cancellationToken = default);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T>DeleteAsync(T entity);
        Task<IList<T>> GetListAsync2(Expression<Func<T, bool>>? predicate = null);

     
    }
}
