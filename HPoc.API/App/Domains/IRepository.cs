using System.Threading.Tasks;

namespace App.Domains
{
    public interface IRepository<TEntity, in TId> : IReadOnlyRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        void Add(TEntity entity);
        Task AddAsync(TEntity entity);
        void Remove(TId id);
        Task RemoveAsync(TId id);
        void Update(TEntity entity);
        Task UpdateAsync(TEntity entity);
    }
}
