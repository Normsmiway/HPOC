using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace App.Domains
{
    public class InMemoryRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        protected Dictionary<TId, TEntity> Entities { get; }
        public int Count => Entities.Count;
        public InMemoryRepository()
        {
            Entities = new Dictionary<TId, TEntity>();
        }
        public void Add(TEntity entity)
        {
            Entities[entity.Id] = entity;
        }

        public Task AddAsync(TEntity entity)
        {
            return Task.Run(() =>
            {
                Add(entity);
            });
        }

        public bool Contains(TId id)
        {
            return Entities.ContainsKey(id);
        }

        public TEntity Get(TId id)
        {
            Entities.TryGetValue(id, out var entity);
            return entity;
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return Entities.Values.AsQueryable().Where(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Entities.Values.ToList();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return Task.Run(() => { return GetAll(); });
        }

        public Task<TEntity> GetAsync(TId id)
        {
            return Task.Run(() => { return Get(id); });
        }

        public Task<IQueryable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Task.Run(() => { return Get(predicate); });
        }

        public void Remove(TId id)
        {
            Entities.Remove(id);
        }

        public Task RemoveAsync(TId id)
        {
            return Task.Run(() => { Remove(id); });
        }

        public void Update(TEntity entity)
        {
            Entities[entity.Id] = entity;
        }

        public Task UpdateAsync(TEntity entity)
        {
            return Task.Run(() => { Update(entity); });
        }
    }
}