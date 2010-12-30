using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private readonly EmployeeRepository _employeeRepository;
        #endregion ------------------- PRIVATE PROPERTIES ----------------------

        #region ---------------------- PUBLIC PROPERTIES ----------------------

        #endregion ------------------- PUBLIC PROPERTIES ----------------------

        #region ------------------------ CONSTRUCTORS -------------------------
        /// <summary>
        /// 
        /// </summary>
        public EmployeeController()
        {
            _employeeRepository = new EmployeeRepository();
        }
        #endregion --------------------- CONSTRUCTORS -------------------------

        #region ----------------------- PRIVATE METHODS ------------------------

        #endregion--------------------- PRIVATE METHODS ------------------------

        #region ----------------------- PUBLIC METHODS ------------------------
        /// <summary>
        /// Return all employees in a collection.
        /// </summary>
        /// <returns></returns>
        public ICollection<IEmployee> Employees()
        {
            return _employeeRepository.FindAll();
        }


        public void AddEmployee(IEmployee entity)
        {
            _employeeRepository.Add(entity);
        }
        #endregion--------------------- PUBLIC METHODS ------------------------
    }
}