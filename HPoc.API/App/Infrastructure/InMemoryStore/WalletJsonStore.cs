using App.Domains;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HPoc.API.App.Infrastructure.InMemoryStore
{
    public class WalletJsonStore<TEntity, TId> : IRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        private readonly string _filePath;
        private readonly JsonSerializerSettings _jsonSerializerSettings;
        private readonly Dictionary<TId, TEntity> _entities;
        const string baseFilePath = "DB";
        public WalletJsonStore()
        {
            _filePath = (Path.Combine(baseFilePath, $"{typeof(TEntity).Name}s.json"));
            EnsureRequiredFilesAreCreated();


            _entities = new Dictionary<TId, TEntity>();
            _jsonSerializerSettings = new JsonSerializerSettings();

            _jsonSerializerSettings.Converters.Add(new StringEnumConverter());
            if (File.Exists(_filePath))
            {
                using (var streamReader = new StreamReader(_filePath))
                {
                    var json = streamReader.ReadToEnd();
                    _entities = JsonConvert.DeserializeObject<Dictionary<TId, TEntity>>(json, _jsonSerializerSettings) ?? new();
                }
            }
        }

        public int Count => _entities.Count;

        public void Add(TEntity entity)
        {
            _entities[entity.Id] = entity;
            Persist();
        }

        public Task AddAsync(TEntity entity)
        {
            return Task.Run(() => Add(entity));
        }

        public bool Contains(TId id)
        {
            return _entities.ContainsKey(id);
        }

        public TEntity Get(TId id)
        {
            return _entities[id];
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Values.AsQueryable().Where(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities.Values.ToList();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return Task.Run(() => GetAll());
        }

        public Task<TEntity> GetAsync(TId id)
        {
            return Task.Run(() => Get(id));
        }

        public Task<IQueryable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Task.Run(() => GetAsync(predicate));
        }

        public void Remove(TId id)
        {
            _entities.Remove(id);
            Persist();
        }
        public void Remove(TEntity entity)
        {
            _entities.Remove(entity.Id);
            Persist();
        }
        public Task RemoveAsync(TId id)
        {
            return Task.Run(() => Remove(id));
        }

        public void Update(TEntity entity)
        {
            _entities[entity.Id] = entity;
            Persist();
        }

        public Task UpdateAsync(TEntity entity)
        {
            return Task.Run(() => Update(entity));
        }

        #region private helper methods
        private void Persist()
        {
            using (var streamWriter = new StreamWriter(_filePath))
            {
                var jsonData = JsonConvert.SerializeObject(_entities, _jsonSerializerSettings);
                streamWriter.Write(jsonData);
            }
        }

        private void EnsureRequiredFilesAreCreated()
        {
            var fileInfo = new FileInfo(_filePath);
            var dir = fileInfo.DirectoryName;
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            if (!File.Exists(_filePath))
                File.Create(_filePath);
        }
        #endregion
    }


}
