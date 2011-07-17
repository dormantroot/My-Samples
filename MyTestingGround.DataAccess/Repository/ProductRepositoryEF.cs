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
    public class ProductRepositoryEF : IProductRepository
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
        public ProductRepositoryEF()
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
        public IEnumerable<IProduct> FindAll()
        {
            throw new NotImplementedException();

        }

      
        public IEnumerable<IProduct> FindWhere(Func<IProduct, bool> predicate)
        {
            return db.Products
                .Include("ProductCostHistories")
                .Include("ProductModel")
                .Where<IProduct>(predicate)
                .ToList<IProduct>();
        }


        public IProduct Get(Expression<Func<IProduct, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(IProduct entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(IProduct entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
        #endregion--------------------- PUBLIC METHODS ------------------------
    }
}
