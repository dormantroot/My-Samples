using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using MyTestingGround.DomainObjects;
using System.Linq.Expressions;

namespace MyTestingGround.DataAccess.Repository
{

    public interface IPurchaseOrderRepository : IRepository<IPurchaseOrderHeader>, IDisposable 
    {       

        /// <summary>
        /// Find details of purchase order header that satisfy the given predicate
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        IEnumerable<IPurchaseOrderHeader> FindDetails(Func<IPurchaseOrderHeader, bool> predicate);
      
    }
}
