using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using MyTestingGround.DomainObjects;

namespace MyTestingGround.DataAccess.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class EmployeeRepository: IEmployeeRepository
    {
        #region ---------------------- PRIVATE PROPERTIES ----------------------
        AdventureWorksEntities db = new AdventureWorksEntities();        
        #endregion ------------------- PRIVATE PROPERTIES ----------------------

        #region ---------------------- PUBLIC PROPERTIES ----------------------

        #endregion ------------------- PUBLIC PROPERTIES ----------------------

        #region ------------------------ CONSTRUCTORS -------------------------
        /// <summary>
        /// 
        /// </summary>
        public EmployeeRepository()
        {

        }
        #endregion --------------------- CONSTRUCTORS -------------------------

        #region ----------------------- PRIVATE METHODS ------------------------

        #endregion--------------------- PRIVATE METHODS ------------------------

        #region ----------------------- PUBLIC METHODS ------------------------
        /// <summary>
        /// Adds the specified Employee entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Add(IEmployee entity)
        {
            Employee employee = (Employee)entity;
            Employee newEmployee = MyTestingGround.DomainObjects.Employee.CreateEmployee( employee.EmployeeID, "1213xxx",
                                209,
                                "malakarra", employee.Title,
                                employee.BirthDate, employee.MaritalStatus,
                                employee.Gender, employee.HireDate,
                                employee.SalariedFlag, employee.VacationHours, employee.SickLeaveHours,
                                employee.CurrentFlag, new Guid("EC84AE09-F9B8-4A15-B4A9-6CCBAB919000"),
                                employee.ModifiedDate                   
                                );

            //newEmployee.Contact = db.Contact.Where<Contact>(q => q.ContactID == 209).FirstOrDefault();
            db.AddToEmployees(newEmployee);           

            db.SaveChanges();
        }


        public void Remove(IEmployee entity){}


        /// <summary>
        /// Finds all employees.
        /// </summary>
        /// <returns></returns>
        public ICollection<IEmployee> FindAll()
        {          
            return db.Employees.OrderBy(q => q.EmployeeID)
                                             .AsEnumerable()
                                             .Cast<IEmployee>()
                                             .ToList()
                                             .AsReadOnly();
        }
        #endregion--------------------- PUBLIC METHODS ------------------------
    }
}