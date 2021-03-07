namespace App.Domains
{
    using System;
    public interface IEntity<TId>
    {
        /// <summary>
        ///     Gets or sets the unique identifier.
        /// </summary>
        /// <value>The unique identifier.</value>
        TId Id { get; }
    }
}
