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
    /// Concrete Employee repository that uses Entity Framework
    /// </summary>
    public class EmployeeRepositoryEF:IEmployeeRepository
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
        public EmployeeRepositoryEF()
        {
             db = new AdventureWorksEntities(); 
        }
        #endregion --------------------- CONSTRUCTORS -------------------------

        #region ----------------------- PRIVATE METHODS ------------------------

        #endregion--------------------- PRIVATE METHODS ------------------------

        #region ----------------------- PUBLIC METHODS ------------------------     


        /// <summary>
        /// Finds all employees.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IEmployee> FindAll()
        {
            return db.Employees.OrderBy(q => q.EmployeeID).AsEnumerable().Cast<IEmployee>().ToList();

        }

        /// <summary>
        /// Find employees based on the given predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public IEnumerable<IEmployee> FindWhere(Func<IEmployee, bool> predicate)
        {
            //ObjectSet<Employee> employees = db.Employees;
            //ObjectSet<PurchaseOrderHeader> purchaseOrderHeaders = db.PurchaseOrderHeaders;

            //var query = from employee in employees
            //            from purchaseOrderHeader in purchaseOrderHeaders
            //            where employee.EmployeeID == purchaseOrderHeader.EmployeeID
            //            select new { employee, purchaseOrderHeader };

            //query.Where(predicate);
            throw new NotImplementedException();

        }

        public IEmployee Get(Expression<Func<IEmployee, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(IEmployee entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(IEmployee entity)
        {
            throw new NotImplementedException();
        }


        public void Dispose()
        {
        }

        #endregion--------------------- PUBLIC METHODS ------------------------
    }
}