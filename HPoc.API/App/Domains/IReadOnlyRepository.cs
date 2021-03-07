using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace App.Domains
{
    public interface IReadOnlyRepository<TEntity, in TId> where TEntity : IEntity<TId>
    {
        int Count { get; }
        bool Contains(TId id);
        TEntity Get(TId id);
        Task<TEntity> GetAsync(TId id);

        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        Task<IQueryable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
