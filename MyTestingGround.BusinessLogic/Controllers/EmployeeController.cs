using System.Collections.Generic;
using MyTestingGround.DataAccess.Repository;
using MyTestingGround.DomainObjects;


namespace MyTestingGround.BusinessLogic.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class EmployeeController
    {
        #region ---------------------- PRIVATE PROPERTIES ----------------------
        private readonly IEmployeeRepository employeeRepository;
        private readonly IPurchaseOrderRepository purchaseOrderHeaderRepository;
        #endregion ------------------- PRIVATE PROPERTIES ----------------------

        #region ---------------------- PUBLIC PROPERTIES ----------------------

        #endregion ------------------- PUBLIC PROPERTIES ----------------------

        #region ------------------------ CONSTRUCTORS -------------------------
        /// <summary>
        /// 
        /// </summary>
        public EmployeeController()
        {
            employeeRepository = new EmployeeRepositoryEF();
            purchaseOrderHeaderRepository = new PurchaseOrderRepositoryEF();
        }
        #endregion --------------------- CONSTRUCTORS -------------------------

        #region ----------------------- PRIVATE METHODS ------------------------

        #endregion--------------------- PRIVATE METHODS ------------------------

        #region ----------------------- PUBLIC METHODS ------------------------
        /// <summary>
        /// Return all employees in a collection.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IEmployee> Employees()
        {
            return employeeRepository.FindAll();
        }      


        public IEnumerable<IPurchaseOrderHeader> RetrieveEmployeePurchaseOrders(IEmployee givenEmployee)
        {
            
            IEnumerable<IPurchaseOrderHeader> orders = purchaseOrderHeaderRepository.FindWhere((p) =>
            {
                return (p as PurchaseOrderHeader).EmployeeID == (givenEmployee as Employee).EmployeeID ? true : false;
            });

            return orders;
        }

        public void AddEmployee(IEmployee entity)
        {
            employeeRepository.Add(entity);
        }
        #endregion--------------------- PUBLIC METHODS ------------------------
    }
}