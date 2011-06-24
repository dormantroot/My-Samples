using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using MyTestingGround.DomainObjects;
using System.Linq.Expressions;

namespace MyTestingGround.DataAccess.Repository
{
    public interface IEmployeeRepository : IRepository<IEmployee>, IDisposable 
    {
        /// <summary>
        /// Gets the specified employee that matches the predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        IEmployee Get(Expression<Func<IEmployee, bool>> predicate);
    }

}
