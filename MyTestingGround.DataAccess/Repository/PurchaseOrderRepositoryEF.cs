using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using MyTestingGround.DomainObjects;
using System.Linq.Expressions;

namespace MyTestingGround.DataAccess.Repository
{

   
    /// <summary>
    /// Concrete PurchaseOrderHeader repository that uses Entity Framework
    /// </summary>
    public class PurchaseOrderRepositoryEF : IPurchaseOrderRepository
    {
        #region ---------------------- PRIVATE PROPERTIES ----------------------
        AdventureWorksEntities db;
        #endregion ------------------- PRIVATE PROPERTIES ----------------------

        #region ---------------------- PUBLIC PROPERTIES ----------------------

        #endregion ------------------- PUBLIC PROPERTIES ----------------------

        #region ------------------------ CONSTRUCTORS -------------------------
        /// <summary>
        /// 
        /// </summary>
        public PurchaseOrderRepositoryEF()
        {
            db = new AdventureWorksEntities();
        }
        #endregion --------------------- CONSTRUCTORS -------------------------

        #region ----------------------- PRIVATE METHODS ------------------------

        #endregion--------------------- PRIVATE METHODS ------------------------

        #region ----------------------- PUBLIC METHODS ------------------------



        /// <summary>
        /// Find all PurchaseOrderHeaderRepository
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IPurchaseOrderHeader> FindAll()
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// Find purchase orders that satisfy the given predicate
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public IEnumerable<IPurchaseOrderHeader> FindWhere(Func<IPurchaseOrderHeader, bool> predicate)
        {            
            return db.PurchaseOrderHeaders.Where<IPurchaseOrderHeader>(predicate).ToList<IPurchaseOrderHeader>();

        }


        /// <summary>
        /// Find details of purchase order header that satisfy the given predicate
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public IEnumerable<IPurchaseOrderHeader> FindDetails(Func<IPurchaseOrderHeader, bool> predicate)
        {
            return db.PurchaseOrderHeaders
                .Include("PurchaseOrderDetails")               
                .Where<IPurchaseOrderHeader>(predicate).ToList<IPurchaseOrderHeader>();
        }

        public IPurchaseOrderHeader Get(Expression<Func<IPurchaseOrderHeader, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(IPurchaseOrderHeader entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(IPurchaseOrderHeader entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
        #endregion--------------------- PUBLIC METHODS ------------------------
    }
}
