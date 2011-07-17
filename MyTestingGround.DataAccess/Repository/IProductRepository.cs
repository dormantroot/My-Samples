using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using MyTestingGround.DomainObjects;
using System.Linq.Expressions;

namespace MyTestingGround.DataAccess.Repository
{
    public interface IProductRepository: IRepository<IProduct>, IDisposable 
    {
        /// <summary>
        /// Gets the specified product that matches the predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        IProduct Get(Expression<Func<IProduct, bool>> predicate);
    }
}
