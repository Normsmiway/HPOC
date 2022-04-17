using App.Domains;
using System;

namespace HPoc.API.App.Infrastructure.Entities
{
    public class BaseEntity<TId> : IEntity<TId>
    {
        public TId Id { get; set; }
    }
}
