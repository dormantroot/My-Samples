using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace MyTestingGround.DataAccess.Repository
{
    public interface IRepository<TEntity>  where TEntity : class
    {
        /// <summary>
        /// Finds all items from repository.
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> FindAll();

        /// <summary>
        /// Finds items from repository that match the predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        IEnumerable<TEntity> FindWhere(Func<TEntity, bool> predicate);      

        /// <summary>
        /// Add item into repository.
        /// </summary>
        /// <param name="item">Item to add to repository.</param>
        void Add(TEntity item);

        /// <summary>
        /// Delete item from repository.
        /// </summary>
        /// <param name="item">Item to delete.</param>
        void Remove(TEntity item);
    }
}
